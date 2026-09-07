namespace DutyRoaster.DTOs
{
    public class LoginResponseDto
    {
        public string Token { get; set; }
        public string FirstName { get; set; }
        public long UserProfileId { get; set; }
        public string LastName { get; set; }
        public DateTime ExpireAt { get; set; }

        
    }
}
