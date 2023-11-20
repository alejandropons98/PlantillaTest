namespace BlazorClient.DTOs.Followups
{
    public class GetFollowupsRequest
    {
        public string Id { get; set; }
        public string RecordId { get; set; }
        public string FollowupTemplateId { get; set; }
        public DateTime Date { get; set; }
        public GetAllFPByProviderRequest FollowupTemplate { get; set; }
        //public List<GetAllByFollowupRequest> Sections { get; set; }
    }
}
