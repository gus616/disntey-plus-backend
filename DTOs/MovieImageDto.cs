using disntney_plus_api.Models;
using System.Text.Json.Serialization;

namespace disntney_plus_api.DTOs
{
    public class MovieImageDto
    {
        public int Id { get; set; }

        public string Url { get; set; } //blob storage URL

        public string Type { get; set; } = "poster"; // poster, hero, thumbnail etc


        // Foreign Key 

        public int MovieId { get; set; }

        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}
