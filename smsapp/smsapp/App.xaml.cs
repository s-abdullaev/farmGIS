using Dna;
using System.Threading.Tasks;
using System.Windows;

namespace smsapp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// Use our own starup method to ensure database created and do other stuff
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            await ApplicationSetupAsync();
        }

        private async Task ApplicationSetupAsync()
        {
            new DefaultFrameworkConstruction()
                .AddDatabase()
                .Build();

            //await IoC.Database.EnsureDataStoreAsync();
        }

    }
}
