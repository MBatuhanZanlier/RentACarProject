using Microsoft.AspNetCore.Mvc;

namespace RentACarProject.ViewComponents.AdminLayout
{
    public class AdminLayoutNavbarComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
