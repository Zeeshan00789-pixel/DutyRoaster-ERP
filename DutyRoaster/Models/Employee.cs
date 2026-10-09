namespace PMLSolution.Core.Entities
{
    public class Employee
    {
        public long Id { get; set; }

        public string? FirstName { get; set; }
        public string? MidleName { get; set; }
        public string? LastName { get; set; }

        public int EmployeeId { get; set; }

        public Guid CompanyIdGUID { get; set; }
        public Guid BranchIdGUID { get; set; }

        public string? FatherNameOrHusband { get; set; }

        public DateTime DOB { get; set; }

        public int CurrentAge { get; set; }

        public bool Gender { get; set; }

        public string? Nationality { get; set; }

        public int visaCategoryId { get; set; }

        public string? Address { get; set; }

        public string? PassportNo { get; set; }

        public string? BRPNo { get; set; }

        public string? NINO { get; set; }

        public string? SiaLicenceNo { get; set; }

        public DateTime SiaExpiry { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Picture { get; set; }

        public string? EmergencyContact { get; set; }

        public string? GuardianName { get; set; }

        public string? GuardianAddres { get; set; }

        public string? GuardianPhone { get; set; }

        public string? GuardianRelation { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public bool Cancelled { get; set; }

        public int SIATypeId { get; set; }

        public bool IsDrivingLicence { get; set; }

        public bool IsVehicle { get; set; }

        public string? CertificateNumber { get; set; }

        public string? DrivingLicenceFile { get; set; }

        public string? EmployeeFile { get; set; }

        public string? IDCardFile { get; set; }

        public string? OtherDocumentsFile { get; set; }

        public string? PassportFile { get; set; }

        public string? SIALicenceFile { get; set; }

        public string? VisaFile { get; set; }
    }
}