namespace ShortUrl.Data.Models
{
    public class User
    {

        public User()
        {
            Urls = new List<Url>();
            
        }
        public int Id { get; set; }

        public int email { get; set; }

        public List<Url> Urls { get; set; }
    }
}
