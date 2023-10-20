using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empleado : BaseEntity
    {
        [Required]
        public int IdEmple { get; set; }
        [Required]
        public string NombreEmple { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }

        [Required]
        public int IdCargoFk { get; set; }
        public Cargo Cargos { get; set; }
        [Required]
        public int IdMunicipio { get; set; }
        public Municipio Municipios { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}