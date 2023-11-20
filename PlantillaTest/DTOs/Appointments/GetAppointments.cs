using BlazorClient.DTOs.Patients;
using BlazorClient.DTOs.Providers;

namespace BlazorClient.DTOs.Appointments
{
    public class GetAppointments
    {
        public string Id { get; set; }
        public string ProviderId { get; set; }
        public string PatientId { get; set; }
        public GetAllPatientsAppointment Patient { get; set; }
        public GetProvider Provider { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string Reason { get; set; }
    }
}
