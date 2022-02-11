using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using WordOfTheDay.AnaliticsMicroservice.Repository.Entities;

namespace WordOfTheDay.AnaliticsMicroservice.Repository
{
    public static class RepositoryServicesConfiguration
    {
        public static void AddRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AnaliticsContext>(options =>
                    options.UseSqlServer(connectionString)/*.LogTo(Console.WriteLine)*/);

            services.AddScoped<IAnaliticsRepository, AnaliticsRepository>();
        }
    }
}
