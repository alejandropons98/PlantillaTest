namespace BlazorClient.DTOs.Feedbacks
{
    public class CreateFeedback
    {
        public string Content { get; set; }
        public int Rating { get; set; }
        public string ProviderId { get; set; }
    }
}
