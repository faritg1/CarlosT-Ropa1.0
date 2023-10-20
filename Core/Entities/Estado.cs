using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Estado : BaseEntity
    {
        [Required]
        public string Descripcion { get; set; }
        
        [Required]
        public int IdTipoEstadoFk { get; set; }
        public TipoEstado TiposEstados { get; set; }

        public ICollection<Prenda> Prendas { get; set; }
        public ICollection<DetalleOrden> DetallesOrdenes { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}