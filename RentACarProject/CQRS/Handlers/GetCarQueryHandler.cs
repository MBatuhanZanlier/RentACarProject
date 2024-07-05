using RentACarProject.CQRS.Results;
using RentACarProject.DAL;

namespace RentACarProject.CQRS.Handlers
{
    public class GetCarQueryHandler
    {
        private readonly Context _context;

        public GetCarQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetCarQueryResult> Handle()
        {
            var values = _context.ForRentCars.Select(x => new GetCarQueryResult
            {
                ForRentCarID = x.ForRentCarID,
                CarBrand = x.CarBrand,
                CarModel = x.CarModel,
                CarKM = x.CarKM,
                CarType = x.CarType,
                CarGearType = x.CarGearType,
                CarTotalPerson = x.CarTotalPerson,
                CarFuelType = x.CarFuelType,
                CarColor = x.CarColor,
                CarRenterPersonMinAge = x.CarRenterPersonMinAge,
                CarEnginePower = x.CarEnginePower,
                ImageUrl = x.ImageUrl,
                CarDayPrice = x.CarDayPrice,

            }).ToList();
            return values;  
        }
    }
}
