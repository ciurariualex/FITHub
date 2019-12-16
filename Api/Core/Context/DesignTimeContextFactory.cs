namespace Core.Context
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    internal sealed class DesignTimeContextFactory : IDesignTimeDbContextFactory<FITHubContext>
    {
        FITHubContext IDesignTimeDbContextFactory<FITHubContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FITHubContext>();
            //optionsBuilder.UseSqlServer("Server=ALEXCIURARIULAP\\SQLEXPRESS; Database=OSFHackathonApp;Trusted_Connection=True;MultipleActiveResultSets=True");
            optionsBuilder.UseSqlServer("Server=tcp:winteriscomingdbserver.database.windows.net,1433;Initial Catalog=WinterIsComing_db;Persist Security Info=False;User ID=winteriscomingadmin;Password=Parola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new FITHubContext(optionsBuilder.Options);
        }
    }
}