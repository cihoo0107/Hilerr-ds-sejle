namespace Hilerrøds_sejle.Model
{
    public class Blog
    {
        public string Titel { get; }
        public string Content { get; }

        public Blog(string titel, string content)
        {
            Titel = titel;
            Content = content;

        }
    }




}
