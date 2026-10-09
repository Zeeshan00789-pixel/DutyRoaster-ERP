namespace PMLSolution.Core.Entities
{
    public class DutyRoster
    {
        public long Id { get; set; }

        public Guid IdGUID { get; set; }

        public string? Desciption { get; set; }

        public string? Code { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal TotalProjectHours { get; set; }

        public long ProjectId { get; set; }

        public Guid CompanyIdGUID { get; set; }

        public Guid BranchIdGUID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public bool Cancelled { get; set; }
    }
}