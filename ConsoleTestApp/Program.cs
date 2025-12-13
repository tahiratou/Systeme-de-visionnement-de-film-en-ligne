using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VisionFlix.Core.Interfaces;
using VisionFlix.Core.Services;
using VisionFlix.Infrastructure.Data;
using VisionFlix.Infrastructure.Repositories;

namespace VisionFlix.ConsoleTestApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== VisionFlix Console Test App ===\n");

            // Configuration de l'injection de dépendances
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    // DbContext
                    services.AddDbContext<VisionFlixDbContext>(options =>
                    options.UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB;Database=VisionFlixDB;Integrated Security=True;TrustServerCertificate=True;"));
                    // Repositories
                    services.AddScoped<IFilmRepository, FilmRepository>();
                    services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();

                    // Services
                    services.AddScoped<IFilmService, FilmService>();
                    services.AddScoped<IUtilisateurService, UtilisateurService>();
                })
                .Build();

            // Récupère les services
            var serviceProvider = host.Services;
            var filmService = serviceProvider.GetRequiredService<IFilmService>();

            // Teste quelque chose
            Console.WriteLine("Récupération des films...");
            var films = await filmService.GetAllFilmsAsync();

            Console.WriteLine($"Nombre de films: {films.Count()}");

            foreach (var film in films)
            {
                Console.WriteLine($"- {film.Titre} ({film.Annee})");
            }

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
