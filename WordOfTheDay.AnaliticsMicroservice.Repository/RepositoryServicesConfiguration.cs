using Microsoft.Extensions.DependencyInjection;
using MassTransit;
using SharedModelsLibrary;
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
                    options.UseSqlServer(connectionString).LogTo(Console.WriteLine));

            services.AddScoped<IAnaliticsRepository, AnaliticsRepository>();
        }
        public static void AddConfiguredMassTransitConsumer(this IServiceCollection services, string host)
        {
            services.AddMassTransit(configuration =>
            {
                configuration.AddConsumer<WordConsumer>();

                configuration.UsingRabbitMq((context, config) =>
                {
                    config.Host(host);

                    config.ReceiveEndpoint("word-queue", cnfg=>
                    {
                        cnfg.ConfigureConsumer<WordConsumer>(context);
                    });
                });
            });

            services.AddMassTransitHostedService();
        }
    }
}
