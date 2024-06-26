using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Contexts
{
    public partial class ExampleContext : DbContext
    {
        public ExampleContext()
        {
        }

        public ExampleContext(DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Example> Example { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=PCGAMER\\SQLEXPRESS;Initial Catalog=EjemploRepositorios;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Example>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_EXAMPLE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
