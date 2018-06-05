using Dna;
using System.Windows;

namespace smsapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var db = Framework.Service<IDataStore>();
            db.EnsureDataStoreAsync();
        }
    }
}
