namespace DTO.Request.Authorize
{
    public class CheckOTPRequestDto
    {
        public string Username { get; set; }
        public string Phone { get; set; }
        public int Otp { get; set; }
    }
}
