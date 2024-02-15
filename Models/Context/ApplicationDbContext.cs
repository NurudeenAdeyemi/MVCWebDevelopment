using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Data seeding with EF context
            builder.Entity<Role>().HasData(
                new Role { Name = "Admin" }, new Role { Name = "Student" }
                );

            // Fluent API validation with EF configuration
            /*  builder.Entity<Role>().Property(r => r.Name)
                  .IsRequired()
                  .HasMaxLength(10);

              builder.Entity<Role>().HasIndex( r => r.Name)
                  .IsUnique();*/

            base.OnModelCreating(builder);
            //builder.Ignore<User>();
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
