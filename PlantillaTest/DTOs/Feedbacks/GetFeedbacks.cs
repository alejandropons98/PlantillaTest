

using static PlantillaTest.Pages.Index;

namespace BlazorClient.DTOs.Feedbacks
{
    public class GetFeedbacks
    {
        public string Id { get; set; }
        public string ProviderId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
        public FormAction Action { get; set; }
    }
}
