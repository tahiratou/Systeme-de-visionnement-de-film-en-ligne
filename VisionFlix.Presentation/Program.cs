using System.Windows.Forms; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
				var configuration = new ConfigurationBuilder()
	                    .SetBasePath(Directory.GetCurrentDirectory())
	                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)  
	                    .Build();

				var services = new ServiceCollection();

                // DbContext
                services.AddDbContext<VisionFlixDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

                // ===== REPOSITORIES =====
                services.AddScoped<IFilmRepository, FilmRepository>();
                services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
                services.AddScoped<ICategorieRepository, CategorieRepository>();
                services.AddScoped<ILangueRepository, LangueRepository>();
                services.AddScoped<IPlanAbonnementRepository, PlanAbonnementRepository>();
                services.AddScoped<ITransactionRepository, TransactionRepository>();
                services.AddScoped<IAchatRepository, AchatRepository>();
                services.AddScoped<IVisionnementRepository, VisionnementRepository>();
                services.AddScoped<INotationRepository, NotationRepository>();

                // ===== SERVICES =====
                services.AddScoped<IFilmService, FilmService>();
                services.AddScoped<IUtilisateurService, UtilisateurService>();
                services.AddSingleton<IAuthentificationService, AuthentificationService>();

                // ===== FORMULAIRES =====
                services.AddTransient<Connexion>();
                services.AddTransient<Inscription>();
                services.AddTransient<Accueil>();
                services.AddTransient<DetailsFilm>();
                services.AddTransient<FormulaireFilm>();
                services.AddTransient<FormulaireCategorie>();
                services.AddTransient<FormulaireLangue>();
                services.AddTransient<FormulairePlanAbonnement>();
                services.AddTransient<FormulaireUtilisateur>();
                services.AddTransient<GestionFilms>();
                services.AddTransient<GestionCategories>();
                services.AddTransient<GestionLangues>();
                services.AddTransient<GestionPlansAbonnement>();
                services.AddTransient<GestionFinances>();
                services.AddTransient<PanneauAdmin>();
                services.AddTransient<ProfilUtilisateur>();
                services.AddTransient<Abonnement>();
                services.AddTransient<FicheFilm>();

                ServiceProvider = services.BuildServiceProvider();

                var connexionForm = ServiceProvider.GetRequiredService<Connexion>();
                System.Windows.Forms.Application.Run(connexionForm);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur au démarrage de l'application :\n\n{ex.Message}\n\nDétails:\n{ex.InnerException?.Message}",
                    "Erreur critique",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}