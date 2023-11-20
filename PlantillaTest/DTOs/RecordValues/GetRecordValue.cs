namespace BlazorClient.DTOs.RecordValues
{
    public class GetRecordValueRequest
    {
        public string Id { get; set; }
        public string FieldId { get; set; }
        public string Value { get; set; }
        public string? FollowupId { get; set; }
    }
}
