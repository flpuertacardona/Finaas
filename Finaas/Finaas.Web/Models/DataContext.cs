using Finaas.Web.Models.Academicas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Academico> Academicos { get; set; }
        public DbSet<Admision> Admisiones { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Boletin> Boletines { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Credito> Creditos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Cuadernillo> Cuadernillos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<OfertaAcademica> OfertaAcademicas { get; set; }
        public DbSet<Prematricula> Prematriculas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Promedio> Promedios { get; set; }
        public DbSet<Seguimiento> Seguimientos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}