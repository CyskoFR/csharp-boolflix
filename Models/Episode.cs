namespace csharp_boolflix.Models
{
    public class Episode
    {
        public int? Id { get; set; }
        public int? Duration { get; set; }
        public int? SeasonNumber { get; set; }
        public int? TvSerieId { get; set; }
        public TvSerie? TVSerie { get; set; }

        public Episode()
        {

        }
    }
}
