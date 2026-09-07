using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProjectName.Models
{
    [Table("ProjectInfo")]
    public class ProjectInfo
    {
        [Key]
        public long Id { get; set; }
        public Guid ProjectGUID { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public Guid CompanyIdGUID { get; set; }
        public Guid BranchIdGUID { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        [Required]
        public bool Cancelled { get; set; }

        [Required]
        public int ProjectStatus { get; set; }
    }
}