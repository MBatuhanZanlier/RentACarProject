using MediatR;
using RentACarProject.Mediator.Results;

namespace RentACarProject.Mediator.Queries
{
    public class SearchCarQuery:IRequest<List<SearchCarQueryResult>>
    {
        public int ReceivingLocationID { get; set; }
        public int DeliveryLocationId { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime DeliveryDate { get; set; }   

        public SearchCarQuery (int receivingLocationId , int deliveryLocationId,DateTime receivingDate, DateTime deliveryDate)
        {
            ReceivingLocationID = receivingLocationId; 
            DeliveryLocationId = deliveryLocationId; 
            ReceivingDate = receivingDate; 
            DeliveryDate = deliveryDate;
        }
    }
}
