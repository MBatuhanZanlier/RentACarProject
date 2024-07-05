namespace RentACarProject.DAL
{
    public class RentACar
    {
        public int RentACarID { get; set; }
        public int ForRentCarID { get; set; }
        public ForRentCar ForRentCar { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ReceivingLocationID { get; set; }
        public ReceivingLocation ReceivingLocation { get; set; }
        public int DeliveryLocationId { get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }
    }
}
