using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace YleRSS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Setup();
        }
        public class NewsItem
        {
            public string? Title { get; set; }
            public string? Link { get; set; }
            public string? Description { get; set; }
        }

        private async void Setup()
        {
            using var client = new HttpClient();

            // YLE RSS returns 403 forbidden if we don't have a user agent
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

            var xml = await client.GetStringAsync("https://yle.fi/rss/uutiset/paauutiset");
            var doc = XDocument.Parse(xml);
            var items = doc.Descendants("item").Select(x => new NewsItem
            {
                Title = x.Element("title")?.Value,
                Link = x.Element("link")?.Value,
                Description = x.Element("description")?.Value
            }).ToList();

            listBox_News.DataSource = items;
            listBox_News.DisplayMember = "Title";
        }

        private void listBox_News_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_News.SelectedItem is NewsItem item)
            {
                ArticleDescription descriptionWindow = new ArticleDescription(item);
                descriptionWindow.Visible = true;
            }
        }
    }
}
