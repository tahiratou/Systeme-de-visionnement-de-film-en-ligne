using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VisionFlix.Core.Interfaces;
using VisionFlix.Core.Services;
using VisionFlix.Infrastructure.Data;
using VisionFlix.Infrastructure.Repositories;
using VisionFlix.WindowsApp.Forms;

namespace VisionFlix.WindowsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

           

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {

                    services.AddDbContext<VisionFlixDbContext>(options =>
                    options.UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB;Database=VisionFlixDB;Integrated Security=True;TrustServerCertificate=True;"),
                    ServiceLifetime.Transient);

                    services.AddScoped<IFilmRepository, FilmRepository>();
                    services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
                    services.AddScoped<IAchatRepository, AchatRepository>();
                    services.AddScoped<ITransactionRepository, TransactionRepository>();
                    services.AddScoped<INotationRepository, NotationRepository>();
                    services.AddScoped<IVisionnementRepository, VisionnementRepository>();
                    services.AddScoped<ICategorieRepository, CategorieRepository>();
                    services.AddScoped<ILangueRepository, LangueRepository>();
                    services.AddScoped<IPlanAbonnementRepository, PlanAbonnementRepository>();

                    services.AddScoped<IFilmService, FilmService>();
                    services.AddScoped<IUtilisateurService, UtilisateurService>();

                    services.AddScoped<IAuthentificationService, AuthentificationService>();
                    services.AddSingleton<ISessionService, SessionService>();


                    services.AddTransient<AccueilPublic>();
                    services.AddTransient<Accueil>();
                    services.AddTransient<Connexion>();
                    services.AddTransient<Inscription>();
                    services.AddTransient<ProfilUtilisateur>();
                    services.AddTransient<DetailsFilmPublic>();

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

                })
                .Build();

           
            // Récupère le service provider
            var serviceProvider = host.Services;

            // Récupère le formulaire de connexion avec injection de dépendances
            var accueilForm = serviceProvider.GetRequiredService<AccueilPublic>();

            // Lance l'application
            Application.Run(accueilForm);
        }
    }
}


