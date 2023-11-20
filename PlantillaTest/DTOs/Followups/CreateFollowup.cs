using BlazorClient.DTOs.RecordValues;
using BlazorClient.DTOs.Sections;

namespace BlazorClient.DTOs.Followups
{
    public class CreateFollowupRequest
    {
        public string RecordId { get; set; }
        public string FollowupTemplateId { get; set; }
        public List<CreateRecordValueRequest> Values { get; set; }
    }
}
