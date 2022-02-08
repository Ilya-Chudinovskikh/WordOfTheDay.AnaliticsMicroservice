using SharedModelsLibrary;
using System.Threading.Tasks;

namespace WordOfTheDay.AnaliticsMicroservice.Repository
{
    public interface IAnaliticsRepository
    {
        Task PostWord(WordInfo word);
    }
}
