using disntney_plus_api.Models;

namespace disntney_plus_api.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection<MovieImage> Images { get; set; } = new List<MovieImage>();
    }
}
