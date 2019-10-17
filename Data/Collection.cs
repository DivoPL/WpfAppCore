using Dapper;
using Data.Models;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;

namespace Data
{
    public static class Collection
    {

        public static ObservableCollection<ArtistModel> GetArtists(string connectionString)
        {
            string sqlArtists = "SELECT * FROM artists;";

            
            var artists = new ObservableCollection<ArtistModel>();
            try
            {
                using var connection = new SQLiteConnection(connectionString);
                artists = new ObservableCollection<ArtistModel>(
                    connection.Query<ArtistModel>(sqlArtists).ToList()
                    );

                artists.CollectionChanged += (sender, e) =>
                {
                    Debug.Print(e.Action.ToString());
                    if (e.Action == NotifyCollectionChangedAction.Add)
                    {
                        foreach (ArtistModel newItem in e.NewItems)
                        {
                            Debug.Print(newItem.ToString());
                        }
                    }
                };
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
            return artists;
        }
    }
}
