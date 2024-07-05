using Microsoft.AspNetCore.Mvc;

namespace RentACarProject.ViewComponents.AdminLayout
{
    public class AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
