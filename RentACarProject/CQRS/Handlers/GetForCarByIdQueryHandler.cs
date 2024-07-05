using Newtonsoft.Json.Linq;
using RentACarProject.CQRS.Quries;
using RentACarProject.CQRS.Results;
using RentACarProject.DAL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RentACarProject.CQRS.Handlers
{
    public class GetForCarByIdQueryHandler
    {
        private readonly Context _context;

        public GetForCarByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetForCarByIdQueryResult Handle(GetCarByIdQuery query)
        {
            var values = _context.ForRentCars.Find(query.Id);
            return new GetForCarByIdQueryResult
            {
              ForRentCarID = values.ForRentCarID, 
              CarBrand=values.CarBrand,  
              CarModel=values.CarModel, 
              CarKM=values.CarKM, 
              CarType=values.CarType, 
              CarGearType=values.CarGearType, 
              CarTotalPerson=values.CarTotalPerson, 
              CarFuelType=values.CarFuelType, 
              CarColor=values.CarColor, 
              CarRenterPersonMinAge=values.CarRenterPersonMinAge, 
              CarEnginePower=values.CarEnginePower, 
              ImageUrl=values.ImageUrl, 
              CarDayPrice=values.CarDayPrice, 

            };
        }
    }
}
