using ASPLesson.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ASPLesson.DAL
{
    public sealed class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }
        
        public DbSet<Log> Logs { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D3L48SP\\SQLEXPRESS;Database=ASPLesson;Trusted_Connection=True;");
            // optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ITHomester;Username=postgres;Password=PuFFik321!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable("Users")
                    .HasKey(k => k.Id);

                builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                builder.Property(p => p.Name)
                    .HasColumnName("Name");

                builder.Property(p => p.Email)
                    .HasColumnName("Email");
                
                builder.Property(p => p.Password)
                    .HasColumnName("Password");
                
                builder.Property(p => p.Role)
                    .HasColumnName("Role");
                
                builder.Property(p => p.IsActive)
                    .HasColumnName("IsActive");
                
                builder.Property(p => p.Balance)
                    .HasColumnName("Balance");
            });
            
            modelBuilder.Entity<Product>(builder =>
            {
                builder.ToTable("Products")
                    .HasKey(k => k.Id);

                builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                builder.Property(p => p.Name)
                    .HasColumnName("Name");
                
                builder.Property(p => p.Description)
                    .HasColumnName("Description");
                
                builder.Property(p => p.Price)
                    .HasColumnName("Price");
            });
            
            modelBuilder.Entity<Log>(builder =>
            {
                builder.ToTable("Logs")
                    .HasKey(k => k.Id);

                builder.Property(p => p.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                builder.Property(p => p.NameSpace)
                    .HasColumnName("NameSpace");
                
                builder.Property(p => p.CurrentTime)
                    .HasColumnName("CurrentTime");
                
                builder.Property(p => p.Exception)
                    .HasColumnName("Exception");
                
                builder.Property(p => p.Level)
                    .HasColumnName("Level");
            });
        }
    }
}