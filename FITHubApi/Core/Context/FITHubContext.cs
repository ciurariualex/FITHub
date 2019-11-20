namespace Core.Context
{
    using Core.Models;
    using Core.Models.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public sealed class FITHubContext : IdentityDbContext<ApplicationUser>
    {
        public FITHubContext(DbContextOptions<FITHubContext> options) : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Workout> Workouts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}