using WordOfTheDay.AnaliticsMicroservice.Repository.Entities;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace WordOfTheDay.AnaliticsMicroservice.Repository
{
    internal class WordConsumer : IConsumer<Word>
    {
        public async Task Consume(ConsumeContext<Word> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Text);
        }
    }
}