

using static PlantillaTest.Pages.Index;

namespace BlazorClient.DTOs.Fields
{
    public class CreateField
    {
        public string Id { get; set; }
        public string SectionId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public FormAction Action { get; set; }
    }
}
