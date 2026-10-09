using DutyRoaster.DTOs.Common;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DutyRoaster.Services
{
    public class CommonService
    {
        private readonly IConfiguration _configuration;

        public CommonService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<List<DropdownDto>> GetCompaniesAsync()
        {
            var list = new List<DropdownDto>();

            using var connection = GetConnection();

            using var command = new SqlCommand(
                "CompanyInfo_GetInfo",
                connection);

            command.CommandType = CommandType.StoredProcedure;

            await connection.OpenAsync();

            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new DropdownDto
                {
                    Guid = reader.GetGuid(reader.GetOrdinal("Guid")),
                    Name = reader["Name"]?.ToString() ?? ""
                });
            }

            return list;
        }

        public async Task<List<DropdownDto>> GetBranchesAsync(Guid companyIdGUID)
        {
            var list = new List<DropdownDto>();

            using var connection = GetConnection();

            using var command = new SqlCommand(
                "Branch_GetByCompanyGUID",
                connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(
                "@CompanyIdGUID",
                SqlDbType.UniqueIdentifier
            ).Value = companyIdGUID;

            await connection.OpenAsync();

            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new DropdownDto
                {
                    Guid = reader.GetGuid(reader.GetOrdinal("Guid")),
                    Name = reader["Name"]?.ToString() ?? ""
                });
            }

            return list;
        }
    }
}