using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class EstadoDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoEstadoFk { get; set; }

    }
}