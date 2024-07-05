using RentACarProject.CQRS.Commands;
using RentACarProject.DAL;

namespace RentACarProject.CQRS.Handlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }  
        public void Handle(RemoveCarCommand command) 
        { 
           var value=_context.ForRentCars.Find(command.ForRentCarID);
            _context.ForRentCars.Remove(value); 
            _context.SaveChanges();
        }
    }
}
