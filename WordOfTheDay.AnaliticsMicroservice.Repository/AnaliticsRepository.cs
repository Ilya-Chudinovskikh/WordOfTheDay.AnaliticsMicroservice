using SharedModelsLibrary;
using System;
using System.Threading.Tasks;
using WordOfTheDay.AnaliticsMicroservice.Repository.Entities;

namespace WordOfTheDay.AnaliticsMicroservice.Repository
{
    class AnaliticsRepository : IAnaliticsRepository
    {
        private readonly AnaliticsContext _context;
        public AnaliticsRepository(AnaliticsContext context)
        {
            _context = context;
        }
        public async Task PostWord(WordInfo wordInfo)
        {
            _context.WordsInfo.Add(wordInfo);
            await _context.SaveChangesAsync();
        }
    }
}
