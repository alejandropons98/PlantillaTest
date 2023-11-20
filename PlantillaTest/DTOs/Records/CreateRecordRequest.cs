using BlazorClient.DTOs.RecordValues;

namespace BlazorClient.DTOs.Records
{
    public class CreateRecordRequest
    {
        public string ProviderId { get; set; }
        public string PatientId { get; set; }
        public string TemplateId { get; set; }
        public List<CreateRecordValueRequest> Values { get; set; }
    }
}
