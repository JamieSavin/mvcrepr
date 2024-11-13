namespace DevTalk.Core.Models
{
    public class CreateDevSpeakerRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; } = string.Empty;

        public string JobTitle { get; set; } = string.Empty;
    }
}
