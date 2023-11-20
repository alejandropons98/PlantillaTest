namespace BlazorClient.DTOs.Patients
{
    public class CreatePatient
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
