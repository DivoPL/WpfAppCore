using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using WpfAppCore;

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
            var connectionString = @"Data Source=C:\Users\sylwia\source\repos\WpfAppCore\WpfAppCore\chinook.db";
            var artists = Collection.GetArtists(connectionString);

            Assert.IsTrue(artists.Count > 0);
        }
    }
}
