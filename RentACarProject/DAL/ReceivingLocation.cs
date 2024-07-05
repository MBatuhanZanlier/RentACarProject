namespace RentACarProject.DAL
{
    public class ReceivingLocation
    { 
        public int ReceivingLocationID { get; set; } 
        public string ReceivingLocationName { get; set; } 
       public List<RentACar> RentACars { get; set; } 
    }
}
