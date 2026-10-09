namespace DutyRoaster.DTOs.Project
{
    public class ProjectInsertDto
    {
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public string? CreatedBy { get; set; }
        public Guid BranchIdGUID { get; set; }
        public Guid CompanyIdGUID { get; set; }
        public int ProjectStatus { get; set; } = 1;
    }
}
