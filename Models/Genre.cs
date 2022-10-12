namespace csharp_boolflix.Models
{
    public class Genre
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public int MediaLinkId { get; set; }
        public MediaLink MediaLink { get; set; }

        public Genre()
        {

        }
    }
}
