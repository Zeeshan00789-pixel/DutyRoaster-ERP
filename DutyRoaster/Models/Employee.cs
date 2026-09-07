using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProjectName.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public long Id { get; set; }     
        public Guid EmployeeIdGUID { get; set; }
        public string? FirstName { get; set; }
        public string? MidleName { get; set; }
        public string? LastName { get; set; }
        public string? FatherNameOrHusband { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public int GenderId { get; set; }

        public int? NationalityId { get; set; }
        public string? Address { get; set; }
        public string? PassportNo { get; set; }
        public string? Phone { get; set; }

        public string? Email { get; set; }
        public Guid CompanyIdGUID { get; set; }
        public Guid BranchIdGUID { get; set; }
        public string? Picture { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        [Required]
        public bool Cancelled { get; set; }


    }
}