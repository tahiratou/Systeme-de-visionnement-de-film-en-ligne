using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;

namespace VisionFlix.Infrastructure.Data
{
    public class VisionFlixDbContext : DbContext
    {
        public VisionFlixDbContext(DbContextOptions<VisionFlixDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Film> Films { get; set; } = null!;
        public DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
        public DbSet<Categorie> Categories { get; set; } = null!;
        public DbSet<Langue> Langues { get; set; } = null!;
        public DbSet<PlanAbonnement> PlansAbonnement { get; set; } = null!;
        public DbSet<Achat> Achats { get; set; } = null!;
        public DbSet<Visionnement> Visionnements { get; set; } = null!;
        public DbSet<Notation> Notations { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===== CONFIGURATION FILM =====
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Titre).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Realisateur).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Prix).HasColumnType("decimal(10,2)");
                entity.Property(e => e.Note).HasColumnType("decimal(3,1)");

                entity.HasIndex(e => e.Titre);
                entity.HasIndex(e => e.Genre);
                entity.HasIndex(e => e.Annee);
            });

            // ===== CONFIGURATION UTILISATEUR =====
            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Solde).HasColumnType("decimal(10,2)");

                entity.HasIndex(e => e.Email).IsUnique();

                // Relation avec PlanAbonnement
                entity.HasOne(e => e.PlanAbonnement)
                    .WithMany(p => p.Utilisateurs)
                    .HasForeignKey(e => e.PlanAbonnementId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // ===== CONFIGURATION PLANABONNEMENT =====
            // ✅ UNIQUEMENT les propriétés qui existent dans ta classe
            modelBuilder.Entity<PlanAbonnement>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Prix).HasColumnType("decimal(10,2)").IsRequired();
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.EstActif).IsRequired();
            });

            // ===== CONFIGURATION CATEGORIE =====
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Nom).IsUnique();
            });

            // ===== CONFIGURATION LANGUE =====
            modelBuilder.Entity<Langue>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Code).IsRequired().HasMaxLength(10);
                entity.HasIndex(e => e.Code).IsUnique();
            });

            // ===== CONFIGURATION ACHAT =====
            modelBuilder.Entity<Achat>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.PrixAchat).HasColumnType("decimal(10,2)");

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

            // ===== CONFIGURATION VISIONNEMENT =====
            modelBuilder.Entity<Visionnement>(entity =>
            {
                entity.HasKey(e => e.Id);

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

            // ===== CONFIGURATION NOTATION =====
            modelBuilder.Entity<Notation>(entity =>
            {
                entity.HasKey(e => e.Id);

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

            // ===== CONFIGURATION TRANSACTION =====
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Montant).HasColumnType("decimal(10,2)");
                entity.Property(e => e.Type).IsRequired().HasMaxLength(50);

                entity.HasOne(e => e.Utilisateur)
                    .WithMany(u => u.Transactions)
                    .HasForeignKey(e => e.UtilisateurId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasIndex(e => e.UtilisateurId);
                entity.HasIndex(e => e.DateTransaction);
            });

            // ===== DONNÉES INITIALES (SEED) =====

            // Seed Plans Abonnement
            modelBuilder.Entity<PlanAbonnement>().HasData(
                new PlanAbonnement
                {
                    Id = 1,
                    Nom = "Basique",
                    Prix = 9.99m,
                    Description = "Accès limité aux films",
                    EstActif = true
                },
                new PlanAbonnement
                {
                    Id = 2,
                    Nom = "Standard",
                    Prix = 14.99m,
                    Description = "Accès illimité aux films, 1 écran",
                    EstActif = true
                },
                new PlanAbonnement
                {
                    Id = 3,
                    Nom = "Premium",
                    Prix = 19.99m,
                    Description = "Accès illimité aux films, 4 écrans, HD",
                    EstActif = true
                }
            );

            // Seed Catégories
            modelBuilder.Entity<Categorie>().HasData(
                new Categorie { Id = 1, Nom = "Action", Description = "Films d'action", EstActive = true },
                new Categorie { Id = 2, Nom = "Comédie", Description = "Films humoristiques", EstActive = true },
                new Categorie { Id = 3, Nom = "Drame", Description = "Films dramatiques", EstActive = true },
                new Categorie { Id = 4, Nom = "Science-Fiction", Description = "Films de science-fiction", EstActive = true },
                new Categorie { Id = 5, Nom = "Thriller", Description = "Films à suspense", EstActive = true }
            );

            // Seed Langues
            modelBuilder.Entity<Langue>().HasData(
                new Langue { Id = 1, Nom = "Français", Code = "fr", EstActive = true },
                new Langue { Id = 2, Nom = "Anglais", Code = "en", EstActive = true },
                new Langue { Id = 3, Nom = "Espagnol", Code = "es", EstActive = true }
            );
        }
    }
}