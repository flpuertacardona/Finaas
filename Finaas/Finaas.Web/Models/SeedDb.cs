using Finaas.Web.Data.Investigacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models
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
            await CheckCientificoAsync();
            await CheckPublicacionAsync();
            await CheckFinanciacionAsync();
            await CheckEjecucionAsync();
        }

        private Task CheckEjecucionAsync()
        {
            if (!_context.Ejecuciones.Any())
            {
                _context.Ejecuciones.Add(new Ejecucion { Nombre = "Ejecución investigación Proyecto 01" });
                _context.Ejecuciones.Add(new Ejecucion { Nombre = "Ejecución investigación Proyecto 02" });
                _context.Ejecuciones.Add(new Ejecucion { Nombre = "Ejecución investigación Proyecto 03" });
                _context.Ejecuciones.Add(new Ejecucion { Nombre = "Ejecución investigación Proyecto 04" });
                _context.Ejecuciones.Add(new Ejecucion { Nombre = "Ejecución investigación Proyecto 05" });
                _context.Ejecuciones.Add(new Ejecucion { Nombre = "Ejecución investigación Proyecto 06" });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckFinanciacionAsync()
        {
            if (!_context.Financiaciones.Any())
            {
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 01" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 02" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 03" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 04" });
                _context.Financiaciones.Add(new Financiacion { Nombre = "Financiación investigación Proyecto 05" });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckPublicacionAsync()
        {
            if (!_context.Publicaciones.Any())
            {
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 01" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 02" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 03" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 04" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 05" });
                _context.Publicaciones.Add(new Publicacion { Nombre = "Publicar resultados investigación Proyecto 06" });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckCientificoAsync()
        {
            if (!_context.Cientificos.Any())
            {
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Ciencias_Basicas });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Ciencias_Economicas });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Ciencias_Humanas });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Ciencias_Sociales });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Expresión_Artistica });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Expresión_Deportiva });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Expresión_Musical });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Lenguas_Extranjeras });
                _context.Cientificos.Add(new Cientifico { Conocimiento = Conocimiento.Tecnología_Informatica });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckActividadAsync()
        {
            if (!_context.Actividades.Any())
            {
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 01" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 02" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 03" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 04" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 05" });
                _context.Actividades.Add(new Actividad { Nombre = "Obtener Financiación Proyecto 06" });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckAgendaAsync()
        {
            if (!_context.Agendas.Any())
            {
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 01" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 02" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 03" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 04" });
                _context.Agendas.Add(new Agenda { Nombre = "Realizar Investigación Proyecto 05" });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckProfesorAsync()
        {
            if (!_context.Profesores.Any())
            {
                _context.Profesores.Add(new Profesor { Nombre = "Fernando Moreno" });
                _context.Profesores.Add(new Profesor { Nombre = "Carlos Jimenez" });
                _context.Profesores.Add(new Profesor { Nombre = "Maria Eugenia Puerta" });
                _context.Profesores.Add(new Profesor { Nombre = "Juan David Henao" });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckProgramaAsync()
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

        private Task CheckGrupoAsync()
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

        private Task CheckCulturaAsync()
        {
            if (!_context.Culturas.Any())
            {
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Agrotech_transformación_mercado_producción });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Ambiente_biodiversidad_recursos_naturales });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Ciencias_aprendizaje });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Ciencias_comportamiento_cambio_social });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Ciudades_inteligentes });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Creación_cultura_arte });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Energías_sostenibles });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Estado_construcción_pacifica_postacuerdos });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Estudios_económicos_empresariales });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Industrias_40_Tecnologías_Convergentes_nano_bio_info_cogno });
                _context.Culturas.Add(new Cultura { CulturaConocimiento = CulturaConocimiento.Salud });
                await _context.SaveChangesAsync();
            }
        }

        private Task CheckEscuelaAsync()
        {
            if (!_context.Escuelas.Any())
            {

                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Ciencias_Basicas});
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Ciencias_Economicas});
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Ciencias_Humanas });
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Ciencias_Sociales });
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Expresión_Artistica });
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Expresión_Deportiva });
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Expresión_Musical });
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Lenguas_Extranjeras });
                _context.Escuelas.Add(new Escuela { Conocimiento = Conocimiento.Tecnología_Informatica });
                await _context.SaveChangesAsync();
            }
        }
    }
}