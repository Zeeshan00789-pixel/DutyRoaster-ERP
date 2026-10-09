namespace PMLSolution.Core.Entities
{
    public class Bank
    {
        public long Id { get; set; }

        public string? Code { get; set; }

        public string? Description { get; set; }

        public Guid CompanyIdGUID { get; set; }

        public Guid BranchIdGUID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public bool Cancelled { get; set; }
    }
}