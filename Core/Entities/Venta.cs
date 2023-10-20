using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Venta : BaseEntity
    {
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdEmpledoFk { get; set; }
        public Empleado Empelados { get; set; }
        [Required]
        public int IdClienteFk { get; set; }
        public Cliente Clientes { get; set; }
        [Required]
        public int IdFormaPagoFk { get; set; }
        public FormaPago FormasPagos { get; set; }

        public ICollection<DetalleVenta> DetallesVentas { get; set; }
    }
}