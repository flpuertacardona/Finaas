using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Estudiante
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Generos Genero { get; set; }
        public GSanguineos GrupoSanguineo { get; set; }
        public int Estrato { get; set; }
        public string CarnetSalud { get; set; }
        public RegimenSalud RegimenSalud { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public EstadosCivil EstadoCivil { get; set; }
        public TiposDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Carnet { get; set; }
        public CategoriasEstudiante Categoria { get; set; }
    }
}
