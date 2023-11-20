using BlazorClient.DTOs.Sections;

namespace BlazorClient.DTOs.Followups
{
        public class GetAllFPByProviderRequest
        {
            public string Id { get; set; }
            public string ProviderId { get; set; }
            public List<GetAllByFollowupRequest> Sections { get; set; }
        }
}
