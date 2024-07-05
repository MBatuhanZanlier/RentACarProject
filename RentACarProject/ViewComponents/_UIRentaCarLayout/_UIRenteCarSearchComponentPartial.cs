using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACarProject.DAL;

namespace RentACarProject.ViewComponents._UIRentaCarLayout
{
    public class _UIRenteCarSearchComponentPartial:ViewComponent
    {  
        private readonly Context _context;
        private readonly IMediator _mediator;
        public _UIRenteCarSearchComponentPartial(Context context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public IViewComponentResult Invoke()
        {
            List<SelectListItem> receivingname = (from x in _context.ReceivingLocations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ReceivingLocationName,
                                               Value = x.ReceivingLocationID.ToString()
                                           }).ToList();
            ViewBag.receivingLocation = receivingname;

            List<SelectListItem> deliveryname = (from x in _context.DeliveryLocations.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.DeliveryLocationName,
                                                Value = x.DeliveryLocationId.ToString()
                                            }).ToList();
            ViewBag.deliveryLocation = deliveryname;
            return View();
        }
    }
}
