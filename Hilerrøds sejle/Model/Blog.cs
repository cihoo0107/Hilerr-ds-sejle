namespace Hilerrøds_sejle.Model
{
    public class Blog
    {
        public string Id { get; set; }
        public string Titel { get; set; }
        public string Content { get; set; }

        public Blog()
        {
            Id = Guid.NewGuid().ToString();
        }

        public Blog(string titel, string content)
        {
            Id = Guid.NewGuid().ToString();
            Titel = titel;
            Content = content;
        }
    }




}
