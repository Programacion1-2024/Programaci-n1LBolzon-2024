using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    IdEditorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EDITORIAL", x => x.IdEditorial);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    IdFormaPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_FORMAPAGO", x => x.IdFormaPago);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENERO", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<long>(type: "bigint", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PERSONA", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnioPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false),
                    IdEditorial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_LIBRO", x => x.IdLibro);
                    table.ForeignKey(
                        name: "FK_Libro_Editorial_IdEditorial",
                        column: x => x.IdEditorial,
                        principalTable: "Editorial",
                        principalColumn: "IdEditorial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    IdAutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadLibrosEscritos = table.Column<int>(type: "int", nullable: false),
                    IdPersona = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTOR", x => x.IdAutor);
                    table.ForeignKey(
                        name: "FK_Autor_Persona_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieneMembrecia = table.Column<bool>(type: "bit", nullable: false),
                    PagaIva = table.Column<bool>(type: "bit", nullable: false),
                    IdPersona = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_CLIENTE", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Persona_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sueldo = table.Column<double>(type: "float", nullable: false),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPersona = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EMPLEADO", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Persona_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateTable(
                name: "CopiaLibro",
                columns: table => new
                {
                    IdCopiaLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_COPIA", x => x.IdCopiaLibro);
                    table.ForeignKey(
                        name: "FK_CopiaLibro_Libro_IdLibro",
                        column: x => x.IdLibro,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerosLibro",
                columns: table => new
                {
                    IdGeneroLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLibro = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENEROLIBRO", x => x.IdGeneroLibro);
                    table.ForeignKey(
                        name: "FK_GenerosLibro_Genero_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "Genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerosLibro_Libro_IdLibro",
                        column: x => x.IdLibro,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLibro",
                columns: table => new
                {
                    IdAutorLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAutor = table.Column<int>(type: "int", nullable: false),
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTORLIBRO", x => x.IdAutorLibro);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Autor_IdAutor",
                        column: x => x.IdAutor,
                        principalTable: "Autor",
                        principalColumn: "IdAutor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Libro_IdLibro",
                        column: x => x.IdLibro,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoTotal = table.Column<double>(type: "float", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdFormaPago = table.Column<int>(type: "int", nullable: false),
                    IdFormaDePago = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdLibro = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_VENTA", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Venta_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_FormaPago_IdFormaPago",
                        column: x => x.IdFormaPago,
                        principalTable: "FormaPago",
                        principalColumn: "IdFormaPago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Libro_IdLibro",
                        column: x => x.IdLibro,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    IdPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPersona = table.Column<int>(type: "int", nullable: false),
                    MontoTotal = table.Column<int>(type: "int", nullable: false),
                    FechaPrestamos = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdFormaPago = table.Column<int>(type: "int", nullable: false),
                    IdCopia = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PRESTAMO", x => x.IdPrestamo);
                    table.ForeignKey(
                        name: "FK_Prestamo_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamo_CopiaLibro_IdCopia",
                        column: x => x.IdCopia,
                        principalTable: "CopiaLibro",
                        principalColumn: "IdCopiaLibro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamo_Empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamo_FormaPago_IdFormaPago",
                        column: x => x.IdFormaPago,
                        principalTable: "FormaPago",
                        principalColumn: "IdFormaPago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamo_Persona_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_IdPersona",
                table: "Autor",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_IdAutor",
                table: "AutorLibro",
                column: "IdAutor");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_IdLibro",
                table: "AutorLibro",
                column: "IdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CopiaLibro_IdLibro",
                table: "CopiaLibro",
                column: "IdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdPersona",
                table: "Empleado",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GenerosLibro_IdGenero",
                table: "GenerosLibro",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_GenerosLibro_IdLibro",
                table: "GenerosLibro",
                column: "IdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_IdEditorial",
                table: "Libro",
                column: "IdEditorial");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdCliente",
                table: "Prestamo",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdCopia",
                table: "Prestamo",
                column: "IdCopia");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdEmpleado",
                table: "Prestamo",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdFormaPago",
                table: "Prestamo",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_PersonaIdPersona",
                table: "Prestamo",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdCliente",
                table: "Venta",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdEmpleado",
                table: "Venta",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdFormaPago",
                table: "Venta",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdLibro",
                table: "Venta",
                column: "IdLibro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLibro");

            migrationBuilder.DropTable(
                name: "GenerosLibro");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "CopiaLibro");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Editorial");
        }
    }
}
