using BlazorClient.DTOs.Followups;
using BlazorClient.DTOs.RecordValues;
using BlazorClient.DTOs.Templates;

namespace BlazorClient.DTOs.Records
{
    public class GetByPatientRequest
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public string ProviderId { get; set; }
        public DateTime CreationDate { get; set; }
        public string TemplateId { get; set; }
        public GetAllByProviderRequest Template { get; set; }
        public List<GetRecordValueRequest> Values { get; set; }
        public List<GetFollowupsRequest>? Followups { get; set; }
    }
}
