﻿using Finaas.Web.Data.Investigacion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class InvestigacionContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Cultura> Culturas { get; set; }
        public DbSet<Ejecucion> Ejecucion { get; set; }
        public DbSet<Encuesta> Encuestas { get; set; }
        public DbSet<Financiacion> Financiaciones { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Ejecucion> Ejecuciones { get; set; }

        public InvestigacionContext(DbContextOptions<InvestigacionContext> options) : base(options)
        {

        }
    }
}