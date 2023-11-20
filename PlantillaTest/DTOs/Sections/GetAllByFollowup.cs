using BlazorClient.DTOs.Fields;

namespace BlazorClient.DTOs.Sections
{
    public class GetAllByFollowupRequest
    {
        public string Id { get; set; }
        public string? FollowupId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public List<GetAllBySectionRequest> Fields { get; set; }
    }
}
