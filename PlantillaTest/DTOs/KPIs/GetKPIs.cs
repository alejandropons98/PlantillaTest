namespace BlazorClient.DTOs.KPIs
{
    public class GetKPIs
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public string ProviderId { get; set; }
        public DateTime Date { get; set; }
    }
}
