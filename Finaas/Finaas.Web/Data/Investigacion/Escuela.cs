using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Escuela
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Disciplina Conocimiento { get; set; }
        public DateTime FechaApertura { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Decano { get; set; }
        public List<Grupo> Grupos { get; set; }
        public List<Programa> Programas { get; set; }
        public List<EjeTematico> EjesTematicos { get; set; }
        // "Sembrando interacciones para una nueva Agenda de conocimiento"
        // "Consolidar comunidad cientifica a través de la interacción"
    }
}