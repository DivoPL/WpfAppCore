using Data.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfAppCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var connStr = ConnectionFactory.GetConnectionString();
            Artists = Data.Collection.GetArtists(connStr);
            var artist = new ArtistModel() { ArtistId = 1, Name = "New Artists" };
            Artists.Add(artist);

            InitializeComponent();

        }

        public ObservableCollection<ArtistModel> Artists { get; private set; }
        
    }
}
