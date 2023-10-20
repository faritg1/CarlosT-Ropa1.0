using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class OrdenDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpledoFk { get; set; }
        public int IdClienteFk { get; set; }
        public int IdEstadoFk { get; set; }
    }
}