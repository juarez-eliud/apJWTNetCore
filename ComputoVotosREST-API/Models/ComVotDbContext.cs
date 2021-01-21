using Microsoft.EntityFrameworkCore;



namespace ComputoVotosREST_API.Models
{
    public class ComVotDbContext : DbContext
    {
        public DbSet<TipoEleccion> Elecciones { get; set; }
        public DbSet<TipoConstitucion> Constituciones { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserClaim> Claims { get; set; }
        public DbSet<Coalicion> Coaliciones { get; set; }

        private const string CONN =
            @"Server=Localhost;
            Database=computoVotos;
            Trusted_Connection=True;
            MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(CONN);

    }
}
