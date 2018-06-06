using System.Data.Entity;
using System.IO;

namespace smsapp
{
    /// <summary>
    /// Helper class for retrieving/updating/inserting ... from/to database
    /// We gonna use SQLite for this application
    /// </summary>
    public class Database : DbContext
    {

        /// <summary>
        /// Data 
        /// </summary>
        public DbSet<User> Todos { set; get; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasKey(a => a.ID);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Database() : base()
        {
        }
    }
}
