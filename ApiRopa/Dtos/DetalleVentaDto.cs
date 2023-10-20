using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class DetalleVentaDto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnit { get; set; }
        public int IdVentaFk { get; set; }
        public int IdInventartioFk { get; set; }
        public int IdTallaFk { get; set; }
    }
}