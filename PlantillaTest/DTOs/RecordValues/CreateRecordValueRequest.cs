namespace BlazorClient.DTOs.RecordValues
{
    public class CreateRecordValueRequest
    {
        public string FieldId { get; set; }
        public string Value { get; set; }
        public string RecordId { get; set; }
    }
}
