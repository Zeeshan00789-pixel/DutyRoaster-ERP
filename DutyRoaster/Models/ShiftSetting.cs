namespace PMLSolution.Core.Entities
{
    public class ShiftSetting
    {
        public int Id { get; set; }

        public int ShiftId { get; set; }

        public string ShiftCode { get; set; }

        public string ShiftName { get; set; }

        public string ShiftDescription { get; set; }

        public TimeSpan ShiftStartTime { get; set; }

        public TimeSpan ShiftEndTime { get; set; }

        public Guid CompanyIdGUID { get; set; }

        public Guid BranchIdGUID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }

        public bool Cancelled { get; set; }
    }
}