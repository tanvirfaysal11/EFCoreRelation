using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreRelation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<Skill> Skills { get; set; }
        //    protected void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.ApplyConfiguration(new CharacterConfig());

        //    }
        //}
        //public class CharacterConfig : IEntityTypeConfiguration<Character>
        //{
        //    public void Configure(EntityTypeBuilder<Character> builder)
        //    {
        //        builder.HasKey(x => x.Id);
        //        builder.Property(x => x.Name);

        //    }
    }

}
