namespace csharp_boolflix.Models
{
    public class MediaLink
    {
        public int? Id { get; set; }
        public string? Year { get; set; }
        public bool? IsNew { get; set; }

        public List<Movie>? Movies { get; set; }

        public List<TvSerie>? TvSeries { get; set; }

        public List<Genre>? Genres { get; set; }

        public List<Actor>? Actors { get; set; }
    }
}