using Microsoft.EntityFrameworkCore;

namespace RentACarProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J7PG414\\SQLEXPRESS;initial catalog=DbCqrsRentACar; integrated Security=true");
        }
        public DbSet<ForRentCar> ForRentCars { get; set; }
        public DbSet<ReceivingLocation> ReceivingLocations { get; set; }
        public DbSet<DeliveryLocation> DeliveryLocations { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
    }
}
