using Microsoft.AspNetCore.Mvc;

namespace RentACarProject.ViewComponents.AdminLayout
{
    public class AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
