using Microsoft.EntityFrameworkCore;
using StudioVoices.Domain.Entities;

namespace StudioVoices.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Commissie> Commissies { get; set; }
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Repertoirestuk> Repertoirestukken { get; set; }
        public DbSet<Zanger> Zangers { get; set; }
    }
}
