namespace Data.Models
{
    public class ArtistModel
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ArtistId: {ArtistId}, Name: {Name}";
        }
    }
}
