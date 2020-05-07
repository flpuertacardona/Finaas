using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Administrativo
{
    public class Empleado
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TiposGenero Genero { get; set; }
        public GruposSanguineo GrupoSanguineo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public EstadosCivil EstadoCivil { get; set; }
        public TiposDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
    }
}
