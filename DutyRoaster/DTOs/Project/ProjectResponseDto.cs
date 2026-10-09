namespace DutyRoaster.DTOs.Project
{
    public class ProjectResponseDto
    {
        public int Id { get; set; }
        public Guid ProjectGUID { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
