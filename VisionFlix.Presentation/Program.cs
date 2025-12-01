using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using VisionFlix.Infrastructure.Data;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Repositories;
using VisionFlix.Application.Interfaces;
using VisionFlix.Application.Services;
using VisionFlix.Presentation.Forms;

namespace VisionFlix.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

      

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=VisionFlixDB;Integrated Security=true;TrustServerCertificate=true;";

            
            services.AddDbContext<VisionFlixDbContext>(
                options => options.UseSqlServer(connectionString),
                ServiceLifetime.Transient);  // ? Résout l'erreur threading

            

            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
            services.AddScoped<ICategorieRepository, CategorieRepository>();
            services.AddScoped<ILangueRepository, LangueRepository>();
            services.AddScoped<IPlanAbonnementRepository, PlanAbonnementRepository>();
            services.AddScoped<IAchatRepository, AchatRepository>();
            services.AddScoped<IVisionnementRepository, VisionnementRepository>();
            services.AddScoped<INotationRepository, NotationRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

           
            services.AddScoped<IFilmService, FilmService>();
            services.AddScoped<IUtilisateurService, UtilisateurService>();
            services.AddScoped<IAuthentificationService, AuthentificationService>();

            
            services.AddTransient<Accueil>();
            services.AddTransient<Connexion>();
            services.AddTransient<Inscription>();
            services.AddTransient<ProfilUtilisateur>();
            services.AddTransient<DetailsFilm>();
            services.AddTransient<Abonnement>();

            services.AddTransient<PanneauAdmin>();
            services.AddTransient<GestionFilms>();
            services.AddTransient<GestionFinances>();
            services.AddTransient<GestionCategories>();
            services.AddTransient<GestionPlansAbonnement>();
            services.AddTransient<GestionLangues>();

            services.AddTransient<FormulaireFilm>();
            services.AddTransient<FormulaireUtilisateur>();
            services.AddTransient<FormulaireCategorie>();
            services.AddTransient<FormulairePlanAbonnement>();
            services.AddTransient<FormulaireLangue>();


            var serviceProvider = services.BuildServiceProvider();

            // Lancer l'application avec le formulaire de connexion
            var connexionForm = serviceProvider.GetRequiredService<Connexion>();
            System.Windows.Forms.Application.Run(connexionForm);
        }
    }
}

