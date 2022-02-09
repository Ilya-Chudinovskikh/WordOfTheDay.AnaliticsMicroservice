using SharedModelsLibrary;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordOfTheDay.AnaliticsMicroservice.Repository.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<WordInfo>> AllInfo()
        {
            var allInfo = await _context.WordsInfo.ToListAsync();

            return allInfo;
        }
    }
}
