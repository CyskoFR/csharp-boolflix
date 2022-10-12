namespace csharp_boolflix.Models
{
    public class Actor
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Country { get; set; }

        public int MediaLinkId { get; set; }
        public MediaLink MediaLink { get; set; }

        public Actor()
        {

        }
    }
}
