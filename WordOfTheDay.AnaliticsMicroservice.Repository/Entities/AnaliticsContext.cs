using Microsoft.EntityFrameworkCore;
using SharedModelsLibrary;

namespace WordOfTheDay.AnaliticsMicroservice.Repository.Entities
{
    public class AnaliticsContext : DbContext
    {
        public AnaliticsContext (DbContextOptions<AnaliticsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<WordInfo> WordsInfo { get; set; }
        public AnaliticsContext()
        {
        }
    }
}
