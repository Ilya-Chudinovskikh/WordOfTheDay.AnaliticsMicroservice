using Microsoft.Extensions.DependencyInjection;
using MassTransit;
using WordOfTheDay.AnaliticsMicroservice.Repository;

namespace WordOfTheDay.AnaliticsMicroservice.Domain
{
    public static class DomainServicesConfiguration
    {
        public static void AddConfiguredMassTransitConsumer(this IServiceCollection services, string host)
        {
            services.AddMassTransit(configuration =>
            {
                configuration.AddConsumer<WordConsumer>();

                configuration.UsingRabbitMq((context, config) =>
                {
                    config.Host(host);

                    config.ReceiveEndpoint("word-queue", cnfg =>
                    {
                        cnfg.ConfigureConsumer<WordConsumer>(context);
                    });
                });
            });

            services.AddMassTransitHostedService();
        }
    }
}
