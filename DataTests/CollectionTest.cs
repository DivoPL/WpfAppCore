using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using WpfAppCore;
using System.IO;

namespace DataTests
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void GetConnectionString()
        {
            var connStr = ConnectionFactory.GetConnectionString();

            Assert.IsNotNull(connStr);
        }

        [TestMethod]
        public void GetArtistsTest()
        {
            var connectionString = $@"Data Source={Directory.GetCurrentDirectory()}\chinook.db";
            var artists = Collection.GetArtists(connectionString);

            Assert.IsTrue(artists.Count > 0);
        }
    }
}
