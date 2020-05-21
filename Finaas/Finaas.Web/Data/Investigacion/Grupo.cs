using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo_Colciencias { get; set; }
        public Profesor Coordinador { get; set; }
        public int EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
        public List<Profesor> Investigadores { get; set; }
        public DateTime FechaApertura { get; set; }
        public int CulturaId { get; set; }
        public Cultura Cultura { get; set; }
        public List<MasterProject> Ejecuciones { get; set; }
        public CategoriaGrupo Categria { get; set; }
        public int Patentes { get; set; }
        public List<Convenio> Convenios { get; set; }
        public List<Laboratorio> Laboratorios { get; set; }
    }
}