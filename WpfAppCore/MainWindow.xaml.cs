
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Data.Models;

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
            //var connectionString = @"Data Source=C:\Users\sylwia\source\repos\WpfAppCore\WpfAppCore\chinook.db";
            Artists = Data.Collection.GetArtists(connStr);
            var artist = new ArtistModel() { ArtistId = 1, Name = "Pawel" };
            Artists.Add(artist);

            InitializeComponent();


        }

        public ObservableCollection<ArtistModel> Artists { get; private set; }
        
    }
}
