using Dna;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace smsapp
{
    public static class FrameworkExtensionMethods
    {
        public static FrameworkConstruction AddDatabase(this FrameworkConstruction construction)
        {
            construction.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                //Setup connection string
                //construction.Configuration.GetConnectionString("DatabaseConnection")
                options.UseSqlite("Data Source=smsapp.db");
            });
            construction.Services.AddScoped<IDataStore>(provider=> new DataStore(provider.GetService<ApplicationDbContext>()));
            return construction;
        }
    }
}
