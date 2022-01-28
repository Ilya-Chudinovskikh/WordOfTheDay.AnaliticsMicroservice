using SharedModelsLibrary;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace WordOfTheDay.AnaliticsMicroservice.Repository
{
    internal class WordConsumer : IConsumer<WordInfo>
    {
        private readonly IAnaliticsRepository _analiticsRepository;
        public WordConsumer(IAnaliticsRepository analiticsRepository)
        {
            _analiticsRepository = analiticsRepository;
        }
        public async Task Consume(ConsumeContext<WordInfo> wordInfoIncoming)
        {
            await Console.Out.WriteLineAsync(wordInfoIncoming.Message.Text);

            await _analiticsRepository.PostWord(
                new WordInfo(
                    wordInfoIncoming.Message.Id, 
                    wordInfoIncoming.Message.Email, 
                    wordInfoIncoming.Message.Text, 
                    wordInfoIncoming.Message.AddTime, 
                    0.0, 
                    0.0
                ));
        }
    }
}