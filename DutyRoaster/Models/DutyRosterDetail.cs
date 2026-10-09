namespace PMLSolution.Core.Entities
{
    public class DutyRosterDetail
    {
        public long Id { get; set; }

        public Guid DutyRoasterIdGUID { get; set; }

        public long EmployeeId { get; set; }

        public DateTime? Date { get; set; }

        public long ProjectId { get; set; }

        public decimal DayHours { get; set; }

        public TimeSpan STime { get; set; }

        public TimeSpan ETime { get; set; }

        public int ShiftId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public bool Cancelled { get; set; }

        public DateTime? ApplicableDate { get; set; }
    }
}