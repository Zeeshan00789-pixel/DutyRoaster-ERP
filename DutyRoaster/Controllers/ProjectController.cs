using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using DutyRoaster.DTOs.Project;
using DutyRoaster.Services;

namespace DutyRoaster.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly CommonService _commonService;

        public ProjectController(CommonService commonService)
        {
            _commonService = commonService;
        }



        [HttpGet("list")]
        public IActionResult GetProjectList(Guid? companyIdGUID, Guid? branchIdGUID, string? search, int pageNumber = 1, int pageSize = 10, string? sortColumn = "Id", string? sortDirection = "DESC")

        {
            try
            {
                var allowedSort = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {"Id", "Name", "ShortDescription", "CompanyName","BranchName", "StartDate", "ProjectStatus", "CreatedDate"};

                if (string.IsNullOrWhiteSpace(sortColumn) || !allowedSort.Contains(sortColumn))
                {
                    sortColumn = "Id";
                }

                sortDirection = string.Equals(sortDirection, "ASC", StringComparison.OrdinalIgnoreCase) ? "ASC" : "DESC";
                if (pageNumber < 1) pageNumber = 1;
                if (pageSize < 1) pageSize = 10;
                if (pageSize > 200) pageSize = 200;

                using (SqlConnection con = _commonService.GetConnection())
                using (SqlCommand cmd = new SqlCommand("ProjectInfo_GetList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CompanyIdGUID", SqlDbType.UniqueIdentifier).Value =
                        (object?)companyIdGUID ?? DBNull.Value;

                    cmd.Parameters.Add("@BranchIdGUID", SqlDbType.UniqueIdentifier).Value =
                        (object?)branchIdGUID ?? DBNull.Value;

                    cmd.Parameters.Add("@Search", SqlDbType.NVarChar, 200).Value =
                        string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim();

                    cmd.Parameters.Add("@PageNumber", SqlDbType.Int).Value = pageNumber;
                    cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                    cmd.Parameters.Add("@SortColumn", SqlDbType.NVarChar, 50).Value = sortColumn;
                    cmd.Parameters.Add("@SortDirection", SqlDbType.NVarChar, 4).Value = sortDirection;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int totalRecords = 0;

                        if (reader.Read())
                        {
                            totalRecords = Convert.ToInt32(reader["TotalRecords"]);
                        }

                        var projects = new List<object>();

                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                projects.Add(new
                                {
                                    id = Convert.ToInt64(reader["Id"]),
                                    projectGUID = reader["ProjectGUID"].ToString(),
                                    name = reader["Name"] as string,
                                    shortDescription = reader["ShortDescription"] as string,
                                    startDate = reader["StartDate"] == DBNull.Value
                                        ? (DateTime?)null
                                        : Convert.ToDateTime(reader["StartDate"]),
                                    createdDate = reader["CreatedDate"] == DBNull.Value
                                        ? (DateTime?)null
                                        : Convert.ToDateTime(reader["CreatedDate"]),
                                    projectStatus = reader["ProjectStatus"] == DBNull.Value
                                        ? 0
                                        : Convert.ToInt32(reader["ProjectStatus"]),
                                    companyIdGUID = reader["CompanyIdGUID"].ToString(),
                                    branchIdGUID = reader["BranchIdGUID"].ToString(),
                                    companyName = reader["CompanyName"] as string,
                                    branchName = reader["BranchName"] as string
                                });
                            }
                        }

                        return Ok(new
                        {
                            items = projects,
                            totalRecords = totalRecords
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Unable to load projects.",
                    error = ex.Message
                });
            }
        }




        [HttpPost("insert")]
        public async Task<IActionResult> Insert(ProjectInsertDto dto)
        {
            try
            {
                using var connection = _commonService.GetConnection();

                using var command = new SqlCommand("ProjectInfo_Insert", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", dto.Name);
                command.Parameters.AddWithValue("@ShortDescription",(object?)dto.ShortDescription ?? DBNull.Value);
                command.Parameters.AddWithValue("@Description", (object?)dto.Description ?? DBNull.Value);
                command.Parameters.AddWithValue("@StartDate", dto.StartDate);
                command.Parameters.AddWithValue("@CreatedBy", (object?)dto.CreatedBy ?? DBNull.Value);
                command.Parameters.AddWithValue("@BranchIdGUID", dto.BranchIdGUID);
                command.Parameters.AddWithValue("@CompanyIdGUID", dto.CompanyIdGUID);
                command.Parameters.AddWithValue("@ProjectStatus", dto.ProjectStatus);



                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    var response = new ProjectResponseDto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ProjectGUID = Guid.Parse(reader["ProjectGUID"].ToString()!),
                        Success = Convert.ToBoolean(reader["Success"]),
                        Message = reader["Message"].ToString()!
                    };

                    return Ok(response);
                }

                return BadRequest(new ProjectResponseDto
                {
                    Success = false,
                    Message = "Project could not be inserted."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProjectResponseDto
                {
                    Success = false,
                    Message = ex.Message
                });
            }
        }



         [HttpPut("{projectGUID}")]
        public async Task<IActionResult> Update(Guid projectGUID,ProjectUpdateDto dto)
        {
            try
            {
                using var connection = _commonService.GetConnection();
                using var command = new SqlCommand("ProjectInfo_Update", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProjectGUID", projectGUID);
                command.Parameters.AddWithValue("@Name", dto.Name);
                command.Parameters.AddWithValue("@ShortDescription", (object?)dto.ShortDescription ?? DBNull.Value);
                command.Parameters.AddWithValue("@Description", (object?)dto.Description ?? DBNull.Value);
                command.Parameters.AddWithValue("@StartDate",dto.StartDate);
                command.Parameters.AddWithValue("@ModifiedBy", (object?)dto.ModifiedBy ?? DBNull.Value);
                command.Parameters.AddWithValue("@BranchIdGUID", dto.BranchIdGUID);
                command.Parameters.AddWithValue("@CompanyIdGUID", dto.CompanyIdGUID);
                command.Parameters.AddWithValue("@ProjectStatus", dto.ProjectStatus);

                await connection.OpenAsync();
                using var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    var success = Convert.ToInt32(reader["Success"]) == 1;


                    var response = new ProjectResponseDto
                    {
                        Success = success,
                        Message = reader["Message"].ToString()!

                    };

                    if (reader["ProjectGUID"] != DBNull.Value)
                    {
                        response.ProjectGUID = Guid.Parse(reader["ProjectGUID"].ToString()!);
                    }
                    return success ? Ok(response):BadRequest(response);

                }
                return BadRequest(new ProjectResponseDto
                    {
                        Success = false,
                        Message = "Project could not be updated."
                    });
            }
            catch (Exception ex)
            {
                return StatusCode(
                    500,
                    new ProjectResponseDto
                    {
                        Success = false,
                        Message = ex.Message
                    });
            }
        }



         [HttpDelete("{projectGUID}")]
        public async Task<IActionResult> Delete(Guid projectGUID)
        {
            try
            {
                using var connection = _commonService.GetConnection();
                using var command = new SqlCommand("ProjectInfo_Delete", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProjectGUID", projectGUID);
                command.Parameters.AddWithValue("@ModifiedBy", DBNull.Value);
                await connection.OpenAsync();
                using var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    var success = Convert.ToInt32(reader["Success"]) == 1;

                    var response = new ProjectResponseDto
                    {
                        Success = success,
                        Message = reader["Message"].ToString()!

                    };

                    if (reader["ProjectGUID"] != DBNull.Value)
                    {
                        response.ProjectGUID = Guid.Parse(reader["ProjectGUID"].ToString()!);
                   }

                    return success ? Ok(response) : BadRequest(response);
                }


                return BadRequest(new ProjectResponseDto
                 {
                    Success = false,
                   Message = "Project could not be deleted."

                });
            }
            catch (Exception ex)
            {
                return StatusCode(
                    500,
                    new ProjectResponseDto
                    {
                        Success = false,
                        Message = ex.Message
                    });
            }
        }





        [HttpGet("{projectGUID}")]
        public async Task<IActionResult> GetProjectByGUID(Guid projectGUID)
        {
            try
            {
                using var connection = _commonService.GetConnection();
                using var command = new SqlCommand("ProjectInfo_GetByGUID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ProjectGUID", SqlDbType.UniqueIdentifier).Value = projectGUID;
                await connection.OpenAsync();
                using var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    var project = new
                    {
                      id = reader["Id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["Id"]),
                      projectGUID = reader["ProjectGUID"] == DBNull.Value ? null : reader["ProjectGUID"].ToString(),
                      name = reader["Name"] == DBNull.Value ? string.Empty : reader["Name"].ToString(),
                      shortDescription = reader["ShortDescription"] == DBNull.Value ? string.Empty : reader["ShortDescription"].ToString(),
                      description = reader["Description"] == DBNull.Value ? string.Empty : reader["Description"].ToString(),
                      startDate = reader["StartDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["StartDate"]),
                     projectStatus = reader["ProjectStatus"] == DBNull.Value ? 1 : Convert.ToInt32(reader["ProjectStatus"]),
                     branchIdGUID = reader["BranchIdGUID"] == DBNull.Value ? null : reader["BranchIdGUID"].ToString(),
                     companyIdGUID = reader["CompanyIdGUID"] == DBNull.Value ? null : reader["CompanyIdGUID"].ToString()
                    };

                    return Ok(new
                    {
                        success = true,
                        data = project
                    });
                }
                return NotFound(new
                {
                    success = false,
                    message = "Project not found."
                });
            }
            catch (Exception ex)
            {
   

                return StatusCode(
                    500,
                    new
                    {
                        success = false,
                        message = "Unable to load project.",
                        error = ex.Message
                    }
                );
            }
        }







    }
}