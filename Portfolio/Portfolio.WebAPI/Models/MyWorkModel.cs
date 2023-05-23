namespace Portfolio.WebAPI.Models
{
    public class MyWorkModel
    {
        public string URL { get; set; }
        public string Title { get; set; }

        public string ImageURL { get; set; }

        public string[] Technologies { get; set; }
        public string Category { get; set; }
    }
}