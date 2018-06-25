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
        /// Users table
        /// </summary>
        public DbSet<User> Users{ get; set; }

        /// <summary>
        /// Users table
        /// </summary>
        public DbSet<Contagion> Contagions { get; set; }

        /// <summary>
        /// Users table
        /// </summary>
        public DbSet<SoilReadings> SoilReadings { get; set; }

        /// <summary>
        /// Users table
        /// </summary>
        public DbSet<Geoposition> Geopositions { get; set; }

        /// <summary>
        /// Users table
        /// </summary>
        public DbSet<Disease> Diseases { get; set; }

        /// <summary>
        /// Users table
        /// </summary>
        public DbSet<Pest> Pests { get; set; }

        /// <summary>
        /// Farmers table
        /// </summary>
        public DbSet<FarmOwner> FarmOwners { set; get; }

        /// <summary>
        /// Farmers table
        /// </summary>
        public DbSet<Farm> Farms { set; get; }

        /// <summary>
        /// Plants table
        /// </summary>
        public DbSet<Plant> Plants { set; get; }

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
            modelBuilder.Entity<FarmOwner>().HasMany<Farm>();

            // TODO: Set up limits
            //modelBuilder.Entity<LoginCredentialsDataModel>().Property(a => a.FirstName).HasMaxLength(50);
        }

        #endregion
    }
}
