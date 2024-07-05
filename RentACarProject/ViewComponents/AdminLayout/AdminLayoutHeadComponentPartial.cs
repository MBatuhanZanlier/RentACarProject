using Microsoft.AspNetCore.Mvc;

namespace RentACarProject.ViewComponents.AdminLayout
{
    public class AdminLayoutHeadComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
