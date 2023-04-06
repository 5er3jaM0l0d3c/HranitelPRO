using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Otdel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otdel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Podrasdel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podrasdel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PodrasdelId = table.Column<int>(type: "int", nullable: true),
                    OtdelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Worker_Otdel",
                        column: x => x.OtdelId,
                        principalTable: "Otdel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Worker_Podrasdel",
                        column: x => x.PodrasdelId,
                        principalTable: "Podrasdel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    Pasport = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    CodeWorker = table.Column<int>(type: "int", nullable: true),
                    GroupeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitors_Groups",
                        column: x => x.GroupeId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Visitors_Worker1",
                        column: x => x.CodeWorker,
                        principalTable: "Worker",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_CodeWorker",
                table: "Visitors",
                column: "CodeWorker");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_GroupeId",
                table: "Visitors",
                column: "GroupeId");

            migrationBuilder.CreateIndex(
                name: "IX_Worker_OtdelId",
                table: "Worker",
                column: "OtdelId");

            migrationBuilder.CreateIndex(
                name: "IX_Worker_PodrasdelId",
                table: "Worker",
                column: "PodrasdelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Worker");

            migrationBuilder.DropTable(
                name: "Otdel");

            migrationBuilder.DropTable(
                name: "Podrasdel");
        }
    }
}
