using SharedModelsLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WordOfTheDay.AnaliticsMicroservice.Domain
{
    public interface IAnaliticsServices
    {
        Task<List<WordInfo>> AllInfo();
    }
}
