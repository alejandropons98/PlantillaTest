using BlazorClient.DTOs.PresetValues;

namespace BlazorClient.DTOs.Fields
{
    public class GetAllBySectionRequest
    {
        public string Id { get; set; }
        public string SectionId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<GetAllByFieldRequest> PresetValues { get; set; }
    }
}
