using static PlantillaTest.Pages.Index;

namespace BlazorClient.DTOs.PresetValues
{
    public class CreatePresetValue
    {
        public string Value { get; set; }
        public string FieldId { get; set; }
        public FormAction Action { get; set; }
    }
}
