using GamesFree.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesFree.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
    
    }
}