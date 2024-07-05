using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACarProject.DAL;
using RentACarProject.Mediator.Queries;
using RentACarProject.Mediator.Results;

namespace RentACarProject.Mediator.Handlers
{
    public class SearchCarQueryHandler : IRequestHandler<SearchCarQuery, List<SearchCarQueryResult>>
    {
        private readonly Context _context;

        public SearchCarQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<SearchCarQueryResult>> Handle(SearchCarQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.RentACars.Include(x => x.ForRentCar).Include(x => x.DeliveryLocation).Include(x => x.ReceivingLocation).Where(x => x.DeliveryLocationId == request.DeliveryLocationId || x.ReceivingLocationID == request.ReceivingLocationID || x.DeliveryDate == request.DeliveryDate || x.ReceivingDate == request.ReceivingDate).ToListAsync();

            return values.Select(x => new SearchCarQueryResult
            {
                ForRentCarID = x.ForRentCarID,
                CarBrand = x.ForRentCar.CarBrand,
                CarModel = x.ForRentCar.CarModel,
                CarKM = x.ForRentCar.CarKM,
                CarType = x.ForRentCar.CarType,
                CarGearType = x.ForRentCar.CarGearType,
                CarTotalPerson = x.ForRentCar.CarTotalPerson,
                CarFuelType = x.ForRentCar.CarFuelType,
                CarColor = x.ForRentCar.CarColor,
                CarRenterPersonMinAge = x.ForRentCar.CarRenterPersonMinAge,
                CarEnginePower = x.ForRentCar.CarEnginePower,
                ImageUrl = x.ForRentCar.ImageUrl,
                CarDayPrice = x.ForRentCar.CarDayPrice,
                DeliveryLocationId=x.DeliveryLocationId, 
                ReceivingLocationID=x.ReceivingLocationID 
            }).ToList();


        }

    }
}
