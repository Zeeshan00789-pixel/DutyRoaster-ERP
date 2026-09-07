using System.ComponentModel.DataAnnotations;

namespace DutyRoaster.Models;

public class CompanyInfo
{
    [Key]
    public long Id { get; set; } 
    public Guid CompanyIdGUID { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int? CityId { get; set; }
    public int? CountryId { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Logo { get; set; }
    public string? Fax { get; set; }
    public string? Website { get; set; }
    public string? NTN { get; set; }
    public string? STRN { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }

    public bool Cancelled { get; set; }

    
}