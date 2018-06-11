using Microsoft.EntityFrameworkCore;
using System.Windows.Input;

namespace smsapp
{
    /// <summary>
    /// The database context for the client data store
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        #region DbSets 

        /// <summary>
        /// The client login credentials
        /// </summary>
        public DbSet<User> Users { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        #endregion

        #region Model Creating

        /// <summary>
        /// Configures the database structure and relationships
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<ICommand>();

            // Fluent API

            // Configure database
            // --------------------------
            //
            // Set Id as primary key
            modelBuilder.Entity<User>().HasKey(a => a.ID);
            
            // TODO: Set up limits
            //modelBuilder.Entity<LoginCredentialsDataModel>().Property(a => a.FirstName).HasMaxLength(50);
        }

        #endregion
    }
}
