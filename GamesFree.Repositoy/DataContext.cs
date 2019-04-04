using GamesFree.Domain;
using Microsoft.EntityFrameworkCore;

namespace GamesFree.Repositoy
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Game> Games { get; set; }
        public DbSet<GameTypeGame> GameTypeGames { get; set; }
        public DbSet<GameUser> GameUsers { get; set; }
        public DbSet<ImageGame> ImageGames { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<TypeGame> TypeGames { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<GameTypeGame>().HasKey(GT => new {GT.GameId, GT.TypeGameId});
            modelBuilder.Entity<GameUser>().HasKey(GU => new {GU.GameId,GU.UserId});
        }
            
        
    }
}