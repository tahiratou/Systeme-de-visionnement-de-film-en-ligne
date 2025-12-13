using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionFlix.Core.Entities; 

namespace VisionFlix.Infrastructure.Data
{
    public class VisionFlixDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; } = null!;
        public DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
        public DbSet<Categorie> Categories { get; set; } = null!;
        public DbSet<Langue> Langues { get; set; } = null!;
        public DbSet<PlanAbonnement> PlansAbonnement { get; set; } = null!;
        public DbSet<Achat> Achats { get; set; } = null!;
        public DbSet<Visionnement> Visionnements { get; set; } = null!;
        public DbSet<Notation> Notations { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;

        public VisionFlixDbContext(DbContextOptions<VisionFlixDbContext> options)
            : base(options)
        {
        }

        public VisionFlixDbContext()
            : base(new DbContextOptionsBuilder<VisionFlixDbContext>()
                    .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VisionFlixDB;Integrated Security=True;TrustServerCertificate=True;")
                  .Options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ═══════════════════════════════════════════════════════════════
            // Configuration Film
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Titre).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Realisateur).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Prix).HasColumnType("decimal(10,2)");
                entity.Property(e => e.Note).HasColumnType("decimal(3,1)");

                entity.Property(e => e.Langue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValue("Français")
                    .HasComment("Langue du film (Français, Anglais, etc.)");

                entity.Property(e => e.EstDisponible)
                    .IsRequired()
                    .HasDefaultValue(true);

                entity.HasIndex(e => e.Titre);
                entity.HasIndex(e => e.Genre);
                entity.HasIndex(e => e.Annee);
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration Utilisateur
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.NomUtilisateur)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.HasIndex(e => e.NomUtilisateur).IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);
                entity.HasIndex(e => e.Email).IsUnique();

                entity.Property(e => e.Nom).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Prenom).IsRequired().HasMaxLength(100);
                entity.Property(e => e.MotDePasse).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Telephone).HasMaxLength(20);
                entity.Property(e => e.Adresse).HasMaxLength(200);
                entity.Property(e => e.Solde).HasColumnType("decimal(10,2)").HasDefaultValue(0);
                entity.Property(e => e.EstAdministrateur).HasDefaultValue(false);
                entity.Property(e => e.EstAbonne).HasDefaultValue(false);
                entity.Property(e => e.DateInscription).HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.DerniereConnexion).IsRequired(false);

                entity.Property(e => e.Langue)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValue("fr")
                    .HasComment("Code ISO de la langue de l'utilisateur (fr, en, es, de)");

                entity.Property(e => e.NotificationsActivees)
                    .IsRequired()
                    .HasDefaultValue(true)
                    .HasComment("Indique si l'utilisateur souhaite recevoir des notifications");

                entity.HasOne(e => e.PlanAbonnement)
                    .WithMany(p => p.Utilisateurs)
                    .HasForeignKey(e => e.PlanAbonnementId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration PlanAbonnement
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<PlanAbonnement>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Prix).HasColumnType("decimal(10,2)").IsRequired();
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.EstActif).IsRequired().HasDefaultValue(true);
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration Categorie
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.EstActive).HasDefaultValue(true);
                entity.HasIndex(e => e.Nom).IsUnique();
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration Langue
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Langue>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Code).IsRequired().HasMaxLength(10);
                entity.Property(e => e.EstActive).HasDefaultValue(true);
                entity.HasIndex(e => e.Code).IsUnique();
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration Achat
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Achat>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.PrixAchat).HasColumnType("decimal(10,2)");
                entity.Property(e => e.DateAchat).HasDefaultValueSql("GETDATE()");

                entity.HasOne(e => e.Utilisateur)
                    .WithMany(u => u.Achats)
                    .HasForeignKey(e => e.UtilisateurId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Film)
                    .WithMany(f => f.Achats)
                    .HasForeignKey(e => e.FilmId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(e => e.UtilisateurId);
                entity.HasIndex(e => e.FilmId);
                entity.HasIndex(e => new { e.UtilisateurId, e.FilmId }).IsUnique();
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration Visionnement
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Visionnement>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.DateVisionnement).HasDefaultValueSql("GETDATE()");

                entity.HasOne(e => e.Utilisateur)
                    .WithMany(u => u.Visionnements)
                    .HasForeignKey(e => e.UtilisateurId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Film)
                    .WithMany(f => f.Visionnements)
                    .HasForeignKey(e => e.FilmId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(e => e.UtilisateurId);
                entity.HasIndex(e => e.FilmId);
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration Notation
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Notation>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Note).IsRequired();
                entity.Property(e => e.DateNotation).HasDefaultValueSql("GETDATE()");

                entity.HasOne(e => e.Utilisateur)
                    .WithMany(u => u.Notations)
                    .HasForeignKey(e => e.UtilisateurId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Film)
                    .WithMany(f => f.Notations)
                    .HasForeignKey(e => e.FilmId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(e => e.FilmId);
                entity.HasIndex(e => new { e.UtilisateurId, e.FilmId }).IsUnique();
            });

            // ═══════════════════════════════════════════════════════════════
            // Configuration Transaction
            // ═══════════════════════════════════════════════════════════════
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Montant).HasColumnType("decimal(10,2)");
                entity.Property(e => e.Type).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.DateTransaction).HasDefaultValueSql("GETDATE()");

                entity.HasOne(e => e.Utilisateur)
                    .WithMany(u => u.Transactions)
                    .HasForeignKey(e => e.UtilisateurId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(e => e.UtilisateurId);
                entity.HasIndex(e => e.DateTransaction);
            });
        }
    }
}

