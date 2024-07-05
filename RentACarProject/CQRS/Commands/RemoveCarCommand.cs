namespace RentACarProject.CQRS.Commands
{
    public class RemoveCarCommand
    {
        public int ForRentCarID { get; set; }

        public RemoveCarCommand(int forRentCarID)
        {
            ForRentCarID = forRentCarID;
        }
    }
}
