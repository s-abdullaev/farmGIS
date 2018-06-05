using Microsoft.EntityFrameworkCore;

namespace smsapp
{
    public class ApplicationDbContext:DbContext
    {
        #region DbSets
        /// <summary>
        /// Users table
        /// </summary>
        public DbSet<User> Users { set; get; }

        /// <summary>
        /// Farm owners table
        /// </summary>
        public DbSet<FarmOwner> FarmOwners { set; get; }

        #endregion

        #region Constructor

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        #endregion

        #region OverrideMethods

        /// <summary>
        /// Configures the database structure 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        #endregion
    }
}
