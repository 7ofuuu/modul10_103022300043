namespace modul10_103022300043
{
    public class Movie
    {
        public string title {  get; set; }
        public string director {  get; set; }
        public List<String> stars { get; set; }
        public string description { get; set; }

        public Movie(string title, string director, List<String> stars, string description)
        {
            this.title = title;
            this.director = director;
            this.stars = stars;
            this.description = description;
        }
    }
}
