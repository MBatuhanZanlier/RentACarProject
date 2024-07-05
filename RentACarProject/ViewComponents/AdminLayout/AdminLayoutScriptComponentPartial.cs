using Microsoft.AspNetCore.Mvc;

namespace RentACarProject.ViewComponents.AdminLayout
{
    public class AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
