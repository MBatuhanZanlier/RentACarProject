using RentACarProject.CQRS.Commands;
using RentACarProject.DAL;

namespace RentACarProject.CQRS.Handlers
{
    public class UpdateForCarCommandHandler
    {
        private readonly Context _context;

        public UpdateForCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateForCarCommand command)
        {
            var values = _context.ForRentCars.Find(command.ForRentCarID);
            values.CarBrand = command.CarBrand;
            values.CarModel = command.CarModel;
            values.CarKM = command.CarKM;
            values.CarType = command.CarType;
            values.CarGearType = command.CarGearType;
            values.CarTotalPerson = command.CarTotalPerson; 
            values.CarFuelType = command.CarFuelType; 
            values.CarColor = command.CarColor; 
            values.CarRenterPersonMinAge = command.CarRenterPersonMinAge; 
            values.CarEnginePower = command.CarEnginePower; 
            values.ImageUrl= command.ImageUrl; 
            values.CarDayPrice = command.CarDayPrice; 
            _context.SaveChanges();
        }
    }
}
