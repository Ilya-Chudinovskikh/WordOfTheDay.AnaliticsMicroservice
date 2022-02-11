using SharedModelsLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WordOfTheDay.AnaliticsMicroservice.Repository
{
    public interface IAnaliticsRepository
    {
        Task PostWord(WordInfo word);
        Task<List<WordInfo>> AllInfo();
    }
}
