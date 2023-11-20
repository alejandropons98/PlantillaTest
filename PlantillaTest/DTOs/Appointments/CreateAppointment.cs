namespace BlazorClient.DTOs.Appointments
{
    public class CreateAppointment
    {
        public string PatientId { get; set; }
        public string ProviderId { get; set; }
        public DateTime Date { get; set; }
    }
}
