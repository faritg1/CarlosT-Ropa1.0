using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public int IdEmple { get; set; }
        public string NombreEmple { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdCargoFk { get; set; }
        public int IdMunicipio { get; set; }
    }
}