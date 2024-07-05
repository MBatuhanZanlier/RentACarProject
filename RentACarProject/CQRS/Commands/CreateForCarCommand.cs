namespace RentACarProject.CQRS.Commands
{
    public class CreateForCarCommand
    {
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
    }
}
