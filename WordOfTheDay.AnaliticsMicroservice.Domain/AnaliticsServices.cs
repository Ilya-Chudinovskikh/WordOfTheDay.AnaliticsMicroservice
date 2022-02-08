using System;
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

    }
}
