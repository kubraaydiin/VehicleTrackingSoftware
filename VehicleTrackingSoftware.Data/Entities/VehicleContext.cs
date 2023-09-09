using Microsoft.EntityFrameworkCore;

namespace VehicleTrackingSoftware.Data.Entities
{
    public class VehicleContext: DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options) { }
        public DbSet<Vehicle> Vehicles { get;set; }
    }
}
