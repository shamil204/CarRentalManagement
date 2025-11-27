namespace CarRentalManagement.Components.Domain
{
    public class customer : BaseDomainModel
    {
        public string DrivingLicense { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }

    }
}
