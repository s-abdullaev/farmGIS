using Dna;

namespace smsapp
{
    /// <summary>
    /// Inversion of Control for storing services/vm and easy acesssing to them
    /// </summary>
    public class IoC
    {
        /// <summary>
        /// Database
        /// </summary>
        public static IDataStore Database => Framework.Service<IDataStore>();

    }
}
