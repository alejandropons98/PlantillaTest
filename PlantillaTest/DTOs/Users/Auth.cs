namespace BlazorClient.DTOs.Users
{
    public class AuthenticationRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AuthenticationReply
    {
        public string JwtToken { get; set; }
    }
}
