using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
           dbContextOptions) : base(dbContextOptions){ }
        public DbSet<Assessment> assessments { get; set; }
        public DbSet<Questions> questions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questions>()
               .HasOne(s => s.assessments)
               .WithMany(c => c.questions)
               .HasForeignKey(s => s.AssessmentId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}
