using Core.Data.Configurations;
using Core.Data.Entities;
using Core.Data.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace Core.Context
{
    public sealed class FITHubContext : DbContext
    {
        public FITHubContext(DbContextOptions<FITHubContext> options) : base(options)
        {
        }

        public DbSet<Diet> Diets { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingWorkout> TrainingWorkouts { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
        }
    }
}