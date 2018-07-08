namespace ComicBookGallery.Models
{
    public class Artist
    {
        public string Role { get; set; }
        public string Name { get; set; }

        public Artist(string role, string name)
        {
            Role = role;
            Name = name;
        }

        public Artist()
        { }
    }
}