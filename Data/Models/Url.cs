namespace ShortUrl.Data.Models
{
    public class Url
    {

        public int Id { get; set; }


        public string OriginalLink { get; set; }


        public string ShortLink { get; set; }

        public int ClickedTime { get; set; }

        public int UserID { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
