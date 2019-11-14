namespace Core.Context
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    internal sealed class DesignTimeContextFactory : IDesignTimeDbContextFactory<FITHubContext>
    {
        FITHubContext IDesignTimeDbContextFactory<FITHubContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FITHubContext>();

            optionsBuilder.UseSqlServer("Server=ALEXCIURARIULAP\\SQLEXPRESS; Database=FITHubDatabase;Trusted_Connection=True;MultipleActiveResultSets=True");

            return new FITHubContext(optionsBuilder.Options);
        }
    }
}