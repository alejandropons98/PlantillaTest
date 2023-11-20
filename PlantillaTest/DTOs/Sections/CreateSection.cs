using static PlantillaTest.Pages.Index;

namespace BlazorClient.DTOs.Sections
{
    public class CreateSection
    {
        public string Id { get; set; }
        public string? TemplateId { get; set; }
        public string? FollowupTemplateId { get; set; }
        public string Name { get; set; }
        public FormAction Action { get; set; }
    }
}
