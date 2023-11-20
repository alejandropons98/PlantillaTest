

using BlazorClient.DTOs.Sections;

namespace BlazorClient.DTOs.Templates
{
    public class GetAllByProviderRequest
    {
        public string Id { get; set; }
        public string ProviderId { get; set; }
        public List<GetAllByTemplateRequest> Sections { get; set; }
    }
}
