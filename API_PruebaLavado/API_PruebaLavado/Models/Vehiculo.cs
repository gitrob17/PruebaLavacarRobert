using System.ComponentModel.DataAnnotations;

namespace API_PruebaLavado.Models
{
    public class Vehiculo
    {
        [Key]
        public int ID_Vehiculo { get; set; }
        public string Placa { get; set; }
        public string Dueno { get; set; }
        public string Marca { get; set; }
    }
}
