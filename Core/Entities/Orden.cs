using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Orden : BaseEntity
    {
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdEmpledoFk { get; set; }
        public Empleado Empleados { get; set; }
        [Required]
        public int IdClienteFk { get; set; }
        public Cliente Clientes { get; set; }
        [Required]
        public int IdEstadoFk { get; set; }
        public Estado Estados { get; set; }

        public ICollection<DetalleOrden> DetallesOrdenes { get; set; }
    }
}