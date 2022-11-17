using API_PruebaLavado.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PruebaLavado.Datos
{
    public class VehiculoDBContext : DbContext
    {
        public VehiculoDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculo { set; get; }
    }
}
