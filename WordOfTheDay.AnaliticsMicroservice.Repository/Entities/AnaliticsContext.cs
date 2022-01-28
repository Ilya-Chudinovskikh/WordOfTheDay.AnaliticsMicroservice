using Microsoft.EntityFrameworkCore;
using SharedModelsLibrary;

namespace WordOfTheDay.AnaliticsMicroservice.Repository.Entities
{
    public class AnaliticsContext : DbContext
    {
        public AnaliticsContext (DbContextOptions<AnaliticsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WordInfo> WordsInfo { get; set; }
        public AnaliticsContext()
        {
        }
    }
}
