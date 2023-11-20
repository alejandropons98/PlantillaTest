namespace BlazorClient.DTOs.Appointments
{
    public class GetAppointmentsByProvider
    {
        public string ProviderId { get; set; }
        public IReadOnlyList<GetAppointments> Appointments { get; set; }
    }
}
