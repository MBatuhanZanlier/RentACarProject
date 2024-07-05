using Microsoft.AspNetCore.Mvc;
using RentACarProject.CQRS.Commands;
using RentACarProject.CQRS.Handlers;
using RentACarProject.CQRS.Quries;

namespace RentACarProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly CreateForCarCommandHandler _createForCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly UpdateForCarCommandHandler _updateForCarCommandHandler;
        private readonly GetForCarByIdQueryHandler _getForCarByIdQueryHandler;
        public AdminController(GetCarQueryHandler getCarQueryHandler, CreateForCarCommandHandler createForCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, UpdateForCarCommandHandler updateForCarCommandHandler, GetForCarByIdQueryHandler getForCarByIdQueryHandler)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _createForCarCommandHandler = createForCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _updateForCarCommandHandler = updateForCarCommandHandler;
            _getForCarByIdQueryHandler = getForCarByIdQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getCarQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(CreateForCarCommand command)
        {
            _createForCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveCar(int id)
        {
            _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCar(int id)
        { 
            var values=_getForCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCar(UpdateForCarCommand command)
        {
            _updateForCarCommandHandler.Handle(command);
            return RedirectToAction("Index");

        }

    }
}
