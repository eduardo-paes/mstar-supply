using Microsoft.EntityFrameworkCore;
using MStartSupply.Models;

namespace MStartSupply.Data
{
    public class MStartSupplyContext : DbContext
    {
        public MStartSupplyContext(DbContextOptions<MStartSupplyContext> options)
            : base(options)
        {
        }

        public DbSet<Mercadoria> Mercadoria { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
    }
}