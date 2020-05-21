using Finaas.Web.Data.Investigacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data
{
    public class SeedDb
    {
        private readonly InvestigacionContext _context;

        public SeedDb(
            InvestigacionContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            await CheckEscuelaAsync();
            await CheckCulturaAsync();
            await CheckGrupoAsync();
            await CheckProgramaAsync();
            await CheckProfesorAsync();
            await CheckAgendaAsync();
            await CheckActividadAsync();
            await CheckPublicacionAsync();
            await CheckFinanciacionAsync();
            await CheckEjecucionAsync();
        }

        private async Task CheckEjecucionAsync()
        {
            if (!_context.MasterProjects.Any())
            {
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 01" });
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 02" });
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 03" });
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 04" });
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 05" });
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 06" });
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 07" });
                _context.MasterProjects.Add(new MasterProject { Nombre = "Ejecución investigación Proyecto 08" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckFinanciacionAsync()
        {
            if (!_context.Financiaciones.Any())
            {
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 01" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 02" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 03" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 04" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 05" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 06" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 07" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckPublicacionAsync()
        {
            if (!_context.Publicaciones.Any())
            {
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 01" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 02" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 03" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 04" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 05" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 06" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 07" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckActividadAsync()
        {
            if (!_context.Actividades.Any())
            {
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 01" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 02" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 03" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 04" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 05" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 06" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 07" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckAgendaAsync()
        {
            if (!_context.Agendas.Any())
            {
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 01" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 02" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 03" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 04" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 05" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 05" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 07" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckProfesorAsync()
        {
            if (!_context.Profesores.Any())
            {
                _context.Profesores.Add(new Profesor { Empleado=  new Empleado { Nombres = "Fernando", PrimerApellido = "Moreno" }});
                _context.Profesores.Add(new Profesor { Empleado = new Empleado { Nombres = "Carlos", PrimerApellido = "Jimenez" } });
                _context.Profesores.Add(new Profesor { Empleado = new Empleado { Nombres = "Arturo", PrimerApellido = "Calle" } });
                _context.Profesores.Add(new Profesor { Empleado = new Empleado { Nombres = "Cesar", PrimerApellido = "Velez" } });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckProgramaAsync()
        {
            if (!_context.Programas.Any())
            {
                _context.Programas.Add(new Programa { Nombre = "Ingenieria de sistemas" });
                _context.Programas.Add(new Programa { Nombre = "Ingenieria Fisica" });
                _context.Programas.Add(new Programa { Nombre = "Ingenieria Agricola" });
                _context.Programas.Add(new Programa { Nombre = "Administración de negocios" });
                _context.Programas.Add(new Programa { Nombre = "Economía" });
                _context.Programas.Add(new Programa { Nombre = "Psicología" });
                _context.Programas.Add(new Programa { Nombre = "Derecho" });
                _context.Programas.Add(new Programa { Nombre = "Comunicación social" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckGrupoAsync()
        {
            if (!_context.Grupos.Any())
            {
                _context.Grupos.Add(new Grupo { Nombre = "Grupo Investigación 01" });
                _context.Grupos.Add(new Grupo { Nombre = "Grupo Investigación 02" });
                _context.Grupos.Add(new Grupo { Nombre = "Grupo Investigación 03" });
                _context.Grupos.Add(new Grupo { Nombre = "Grupo Investigación 04" });
                _context.Grupos.Add(new Grupo { Nombre = "Grupo Investigación 05" });
                _context.Grupos.Add(new Grupo { Nombre = "Grupo Investigación 06" });
                _context.Grupos.Add(new Grupo { Nombre = "Grupo Investigación 07" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCulturaAsync()
        {
            if (!_context.Culturas.Any())
            {
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Agrotech_transformación_mercado_producción });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Ambiente_biodiversidad_recursos_naturales });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Ciencias_aprendizaje });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Ciencias_comportamiento_cambio_social });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Ciudades_inteligentes });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Creación_cultura_arte });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Energías_sostenibles });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Estado_construcción_pacifica_postacuerdos });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Estudios_económicos_empresariales });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Industrias_40_Tecnologías_Convergentes_nano_bio_info_cogno });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = AgendaConocimiento.Salud });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckEscuelaAsync()
        {
            if (!_context.Escuelas.Any())
            {
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Administración});
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Ciencias});
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Derecho});
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Economía_Finanzas});
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Expresión_Artistica});
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Expresión_Deportiva});
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Expresión_Musical });
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Humanidades});
                _context.Escuelas.Add(new Escuela { Conocimiento = Disciplina.Lenguas_Extranjeras });
                await _context.SaveChangesAsync();
            }
        }
    }
}