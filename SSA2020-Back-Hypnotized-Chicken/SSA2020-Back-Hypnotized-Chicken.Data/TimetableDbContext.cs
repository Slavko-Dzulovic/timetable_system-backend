using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data
{
    public class TimetableDbContext : DbContext
    {
        public DbSet<Classroom> Classrooms  { get; set; }
        public DbSet<Lecturer> Lecturers  { get; set; }
        public DbSet<Schedule> Schedules  { get; set; }
        public DbSet<Subject> Subjects  { get; set; }
        public DbSet<Term> Terms  { get; set; }

        
        public TimetableDbContext(DbContextOptions<TimetableDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            AddTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is ITimestampable && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((ITimestampable)entity.Entity).CreatedAt = DateTime.UtcNow;
                }

                ((ITimestampable)entity.Entity).UpdatedAt = DateTime.UtcNow;
            }
        }
    }
}