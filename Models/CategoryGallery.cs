namespace disntney_plus_api.Models
{
    public class CategoryGallery
    {
        public int Id { get; set; }       
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        //Foreign Key
        public string CategoryId { get; set; }
    }
}
