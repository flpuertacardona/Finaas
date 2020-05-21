using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TiposGenero Genero { get; set; }
        public GruposSanguineo GrupoSanguineo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public EstadosCivil EstadoCivil { get; set; }
        public TiposDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
        //TODO modificar propiedad para almacenar lista de imagenes
        public string Imagenes { get; set; }
        public string NombreCompleto
        {
            get
            {
                return (PrimerApellido + " " + SegundoApellido + "," + Nombres).ToUpper();
            }
        }
    }
}