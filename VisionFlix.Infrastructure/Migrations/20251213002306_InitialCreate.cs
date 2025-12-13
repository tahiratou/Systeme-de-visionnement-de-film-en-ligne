using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisionFlix.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EstActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Realisateur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<decimal>(type: "decimal(3,1)", nullable: false),
                    Langue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Français", comment: "Langue du film (Français, Anglais, etc.)"),
                    Duree = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Synopsis = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Prix = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EstDisponible = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DateAjout = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Langues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EstActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlansAbonnement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansAbonnement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Solde = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    EstAdministrateur = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EstAbonne = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PlanAbonnementId = table.Column<int>(type: "int", nullable: true),
                    Langue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "fr", comment: "Code ISO de la langue de l'utilisateur (fr, en, es, de)"),
                    NotificationsActivees = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indique si l'utilisateur souhaite recevoir des notifications"),
                    DateExpirationAbonnement = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateInscription = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DerniereConnexion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_PlansAbonnement_PlanAbonnementId",
                        column: x => x.PlanAbonnementId,
                        principalTable: "PlansAbonnement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Achats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    PrixAchat = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achats_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Achats_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<int>(type: "int", nullable: false),
                    Commentaire = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DateNotation = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notations_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notations_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Montant = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DateTransaction = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visionnements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    DateVisionnement = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ProgressionEnSecondes = table.Column<int>(type: "int", nullable: true),
                    EstComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visionnements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visionnements_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visionnements_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achats_FilmId",
                table: "Achats",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Achats_UtilisateurId",
                table: "Achats",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Achats_UtilisateurId_FilmId",
                table: "Achats",
                columns: new[] { "UtilisateurId", "FilmId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Nom",
                table: "Categories",
                column: "Nom",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Films_Annee",
                table: "Films",
                column: "Annee");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Genre",
                table: "Films",
                column: "Genre");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Titre",
                table: "Films",
                column: "Titre");

            migrationBuilder.CreateIndex(
                name: "IX_Langues_Code",
                table: "Langues",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notations_FilmId",
                table: "Notations",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Notations_UtilisateurId_FilmId",
                table: "Notations",
                columns: new[] { "UtilisateurId", "FilmId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DateTransaction",
                table: "Transactions",
                column: "DateTransaction");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UtilisateurId",
                table: "Transactions",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_Email",
                table: "Utilisateurs",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_NomUtilisateur",
                table: "Utilisateurs",
                column: "NomUtilisateur",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_PlanAbonnementId",
                table: "Utilisateurs",
                column: "PlanAbonnementId");

            migrationBuilder.CreateIndex(
                name: "IX_Visionnements_FilmId",
                table: "Visionnements",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Visionnements_UtilisateurId",
                table: "Visionnements",
                column: "UtilisateurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achats");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Langues");

            migrationBuilder.DropTable(
                name: "Notations");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Visionnements");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "PlansAbonnement");
        }
    }
}
