namespace CarRentalManagement.Components.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime Dateout    { get; set; }
        public DateTime Datein { get; set; }
        public int VehicleID { get; set; }
        public int CustormerID { get; set; }
    }
}
