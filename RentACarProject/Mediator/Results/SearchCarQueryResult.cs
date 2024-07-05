namespace RentACarProject.Mediator.Results
{
    public class SearchCarQueryResult
    {
        public int ForRentCarID { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarKM { get; set; }
        public string CarType { get; set; }
        public bool CarGearType { get; set; }
        public string CarTotalPerson { get; set; }
        public string CarFuelType { get; set; }
        public string CarColor { get; set; }
        public string CarRenterPersonMinAge { get; set; }
        public string CarEnginePower { get; set; }
        public string ImageUrl { get; set; }
        public decimal CarDayPrice { get; set; }
        public int DeliveryLocationId { get; set; }
        public int ReceivingLocationID { get; set; }
    }
}
