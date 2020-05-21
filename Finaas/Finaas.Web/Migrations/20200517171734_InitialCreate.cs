using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finaas.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Culturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    CulturaConocimiento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<int>(nullable: false),
                    GrupoSanguineo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<int>(nullable: false),
                    TipoDocumento = table.Column<int>(nullable: false),
                    Documento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    AgendaId = table.Column<int>(nullable: false),
                    FechaActividad = table.Column<DateTime>(nullable: false),
                    CategoriaAprociacion = table.Column<int>(nullable: false),
                    ProgrmaId = table.Column<int>(nullable: false),
                    ProgramaId = table.Column<int>(nullable: true),
                    Categoria = table.Column<int>(nullable: false),
                    Regulacion = table.Column<int>(nullable: false),
                    UnidadApoyo = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Lugar = table.Column<string>(nullable: true),
                    PublicacionId = table.Column<int>(nullable: true),
                    CategoriaProyecto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoId = table.Column<int>(nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    GrupoId = table.Column<int>(nullable: true),
                    Conocimiento = table.Column<int>(nullable: false),
                    CategoriaInvestigador = table.Column<int>(nullable: false),
                    AsignaturaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesores_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escuelas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Conocimiento = table.Column<int>(nullable: false),
                    FechaApertura = table.Column<DateTime>(nullable: false),
                    ProfesorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escuelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Escuelas_Profesores_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EjesTematico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    EscuelaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EjesTematico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EjesTematico_Escuelas_EscuelaId",
                        column: x => x.EscuelaId,
                        principalTable: "Escuelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    EscuelaId = table.Column<int>(nullable: false),
                    FechaApertura = table.Column<DateTime>(nullable: false),
                    CulturaId = table.Column<int>(nullable: false),
                    Categria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupos_Culturas_CulturaId",
                        column: x => x.CulturaId,
                        principalTable: "Culturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grupos_Escuelas_EscuelaId",
                        column: x => x.EscuelaId,
                        principalTable: "Escuelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Categoria = table.Column<int>(nullable: false),
                    EscuelaId = table.Column<int>(nullable: false),
                    ProfesorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programas_Escuelas_EscuelaId",
                        column: x => x.EscuelaId,
                        principalTable: "Escuelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programas_Profesores_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ejecuciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    FechaAprobacion = table.Column<DateTime>(nullable: false),
                    FechaIniciacion = table.Column<DateTime>(nullable: false),
                    Presupuesto = table.Column<float>(nullable: false),
                    DisponibilidadPresupuestal = table.Column<string>(nullable: true),
                    UnidadApoyo = table.Column<int>(nullable: false),
                    Regulacion = table.Column<int>(nullable: false),
                    Categoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejecuciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ejecuciones_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Encuestas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    FechaPublicacion = table.Column<DateTime>(nullable: false),
                    UrlResultados = table.Column<string>(nullable: true),
                    CulturaConocimiento = table.Column<int>(nullable: false),
                    GruposInvestigacionId = table.Column<int>(nullable: false),
                    GrupoInvestigacionId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuestas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Encuestas_Grupos_GrupoInvestigacionId",
                        column: x => x.GrupoInvestigacionId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    FechaPublicacion = table.Column<DateTime>(nullable: false),
                    UrlResultados = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    Revista = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Categoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    EscuelaId = table.Column<int>(nullable: false),
                    ProgramaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Escuelas_EscuelaId",
                        column: x => x.EscuelaId,
                        principalTable: "Escuelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Programas_ProgramaId",
                        column: x => x.ProgramaId,
                        principalTable: "Programas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    FechaActividad = table.Column<DateTime>(nullable: false),
                    MsterProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendas_Ejecuciones_MsterProjectId",
                        column: x => x.MsterProjectId,
                        principalTable: "Ejecuciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Financiaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    FuenteRecursos = table.Column<int>(nullable: false),
                    CategoriasRecursos = table.Column<int>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<float>(nullable: false),
                    Disponible = table.Column<float>(nullable: false),
                    FechaDisponible = table.Column<DateTime>(nullable: false),
                    EjecucionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financiaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Financiaciones_Ejecuciones_EjecucionId",
                        column: x => x.EjecucionId,
                        principalTable: "Ejecuciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_AgendaId",
                table: "Actividades",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_ProgramaId",
                table: "Actividades",
                column: "ProgramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_PublicacionId",
                table: "Actividades",
                column: "PublicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_GrupoId",
                table: "Agendas",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_MsterProjectId",
                table: "Agendas",
                column: "MsterProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_EscuelaId",
                table: "Asignaturas",
                column: "EscuelaId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_ProgramaId",
                table: "Asignaturas",
                column: "ProgramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ejecuciones_GrupoId",
                table: "Ejecuciones",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_EjesTematico_EscuelaId",
                table: "EjesTematico",
                column: "EscuelaId");

            migrationBuilder.CreateIndex(
                name: "IX_Encuestas_GrupoInvestigacionId",
                table: "Encuestas",
                column: "GrupoInvestigacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuelas_ProfesorId",
                table: "Escuelas",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Financiaciones_EjecucionId",
                table: "Financiaciones",
                column: "EjecucionId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_CulturaId",
                table: "Grupos",
                column: "CulturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_EscuelaId",
                table: "Grupos",
                column: "EscuelaId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_AsignaturaId",
                table: "Profesores",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_EmpleadoId",
                table: "Profesores",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_GrupoId",
                table: "Profesores",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Programas_EscuelaId",
                table: "Programas",
                column: "EscuelaId");

            migrationBuilder.CreateIndex(
                name: "IX_Programas_ProfesorId",
                table: "Programas",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_GrupoId",
                table: "Publicaciones",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Agendas_AgendaId",
                table: "Actividades",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Programas_ProgramaId",
                table: "Actividades",
                column: "ProgramaId",
                principalTable: "Programas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Publicaciones_PublicacionId",
                table: "Actividades",
                column: "PublicacionId",
                principalTable: "Publicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesores_Grupos_GrupoId",
                table: "Profesores",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesores_Asignaturas_AsignaturaId",
                table: "Profesores",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Programas_ProgramaId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesores_Grupos_GrupoId",
                table: "Profesores");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Escuelas_EscuelaId",
                table: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "EjesTematico");

            migrationBuilder.DropTable(
                name: "Encuestas");

            migrationBuilder.DropTable(
                name: "Financiaciones");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Ejecuciones");

            migrationBuilder.DropTable(
                name: "Programas");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Culturas");

            migrationBuilder.DropTable(
                name: "Escuelas");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
