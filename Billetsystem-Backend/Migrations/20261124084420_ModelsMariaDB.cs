using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Billetsystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ModelsMariaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BilletTyper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Beskrivelse = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilletTyper", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Navn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Priskategorier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Kategori = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pris = table.Column<int>(type: "int", nullable: false),
                    Farve = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priskategorier", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Navn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teatersale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Navn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kapacitet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatersale", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Brugere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Navn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RolleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brugere", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brugere_Roller_RolleId",
                        column: x => x.RolleId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Forestillinger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Beskrivelse = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KortBeskrivelse = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalgsType = table.Column<int>(type: "int", nullable: false),
                    TeatersalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forestillinger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forestillinger_Teatersale_TeatersalId",
                        column: x => x.TeatersalId,
                        principalTable: "Teatersale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pladser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TeatersalId = table.Column<int>(type: "int", nullable: false),
                    Raekke = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PladsNummer = table.Column<int>(type: "int", nullable: false),
                    Omraade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PriskategoriId = table.Column<int>(type: "int", nullable: false),
                    BegraensetUdsigt = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pladser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pladser_Priskategorier_PriskategoriId",
                        column: x => x.PriskategoriId,
                        principalTable: "Priskategorier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pladser_Teatersale_TeatersalId",
                        column: x => x.TeatersalId,
                        principalTable: "Teatersale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Opfoerelser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dato = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Tid = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ForestillingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opfoerelser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opfoerelser_Forestillinger_ForestillingId",
                        column: x => x.ForestillingId,
                        principalTable: "Forestillinger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bestillinger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KundeId = table.Column<int>(type: "int", nullable: false),
                    OpfoerelseId = table.Column<int>(type: "int", nullable: false),
                    BestillingDato = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BestillingStatus = table.Column<int>(type: "int", nullable: false),
                    TotalPris = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bestillinger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bestillinger_Kunder_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bestillinger_Opfoerelser_OpfoerelseId",
                        column: x => x.OpfoerelseId,
                        principalTable: "Opfoerelser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Billeter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BestilingId = table.Column<int>(type: "int", nullable: false),
                    OpfoerelseId = table.Column<int>(type: "int", nullable: false),
                    BilletTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billeter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billeter_Bestillinger_BestilingId",
                        column: x => x.BestilingId,
                        principalTable: "Bestillinger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Billeter_BilletTyper_BilletTypeId",
                        column: x => x.BilletTypeId,
                        principalTable: "BilletTyper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Billeter_Opfoerelser_OpfoerelseId",
                        column: x => x.OpfoerelseId,
                        principalTable: "Opfoerelser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bestillinger_KundeId",
                table: "Bestillinger",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bestillinger_OpfoerelseId",
                table: "Bestillinger",
                column: "OpfoerelseId");

            migrationBuilder.CreateIndex(
                name: "IX_Billeter_BestilingId",
                table: "Billeter",
                column: "BestilingId");

            migrationBuilder.CreateIndex(
                name: "IX_Billeter_BilletTypeId",
                table: "Billeter",
                column: "BilletTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Billeter_OpfoerelseId",
                table: "Billeter",
                column: "OpfoerelseId");

            migrationBuilder.CreateIndex(
                name: "IX_Brugere_RolleId",
                table: "Brugere",
                column: "RolleId");

            migrationBuilder.CreateIndex(
                name: "IX_Forestillinger_TeatersalId",
                table: "Forestillinger",
                column: "TeatersalId");

            migrationBuilder.CreateIndex(
                name: "IX_Opfoerelser_ForestillingId",
                table: "Opfoerelser",
                column: "ForestillingId");

            migrationBuilder.CreateIndex(
                name: "IX_Pladser_PriskategoriId",
                table: "Pladser",
                column: "PriskategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Pladser_TeatersalId",
                table: "Pladser",
                column: "TeatersalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billeter");

            migrationBuilder.DropTable(
                name: "Brugere");

            migrationBuilder.DropTable(
                name: "Pladser");

            migrationBuilder.DropTable(
                name: "Bestillinger");

            migrationBuilder.DropTable(
                name: "BilletTyper");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Priskategorier");

            migrationBuilder.DropTable(
                name: "Kunder");

            migrationBuilder.DropTable(
                name: "Opfoerelser");

            migrationBuilder.DropTable(
                name: "Forestillinger");

            migrationBuilder.DropTable(
                name: "Teatersale");
        }
    }
}
