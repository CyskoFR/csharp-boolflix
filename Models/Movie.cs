namespace csharp_boolflix.Models
{
    public class Movie : Media
    {
        public int? Duration { get; set; }

        public int? MediaLinkId { get; set; }
        public MediaLink? MediaLink { get; set; }

        public Movie()
        {

        }
    }
}
