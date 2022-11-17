using API_PruebaLavado.Datos;
using API_PruebaLavado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace API_PruebaLavado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : Controller
    {
        private readonly VehiculoDBContext dBContext;

        public VehiculosController(VehiculoDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetVehiculos()
        {
            
            return Ok(await dBContext.Vehiculo.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddVehiculos(AddVehiculoModel newVehiculo)
        {
            var vehiculo = new Vehiculo()
            {
                //ID_Vehiculo = Guid.NewGuid(),
                Placa = newVehiculo.Placa,
                Dueno = newVehiculo.Dueno,
                Marca = newVehiculo.Marca

            };

            await dBContext.Vehiculo.AddAsync(vehiculo);
            await dBContext.SaveChangesAsync();

            return Ok(vehiculo);
        }

    }
}
