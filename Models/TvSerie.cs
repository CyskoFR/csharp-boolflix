namespace csharp_boolflix.Models
{
    public class TvSerie : Media
    {
        public int? Duration { get; set; }

        public int? MediaLinkId { get; set; }
        public MediaLink? MediaLink { get; set; }

        public TvSerie()
        {

        }
    }
}
