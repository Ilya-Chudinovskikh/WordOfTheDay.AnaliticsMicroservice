using SharedModelsLibrary;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace WordOfTheDay.AnaliticsMicroservice.Repository
{
    internal class WordConsumer : IConsumer<WordInfo>
    {
        public async Task Consume(ConsumeContext<WordInfo> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Text);
        }
    }
}