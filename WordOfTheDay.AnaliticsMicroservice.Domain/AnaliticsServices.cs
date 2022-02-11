using SharedModelsLibrary;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordOfTheDay.AnaliticsMicroservice.Repository;

namespace WordOfTheDay.AnaliticsMicroservice.Domain
{
    public class AnaliticsServices : IAnaliticsServices
    {
        private readonly IAnaliticsRepository _analiticsRepository;
        public AnaliticsServices(IAnaliticsRepository analiticsRepository)
        {
            _analiticsRepository = analiticsRepository;
        }
        public async Task<List<WordInfo>> AllInfo()
        {
            var allInfo = await _analiticsRepository.AllInfo();

            return allInfo;
        }

    }
}
