using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace YleRSS
{
    public partial class Main : Form
    {
        List<RecentNewsItem> recents = new List<RecentNewsItem>();

        string recentsFilePath = Path.Combine(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            "recents.txt"
        );

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

        public class RecentNewsItem : NewsItem { }

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

            this.listBox_News.DataSource = items;
            this.listBox_News.DisplayMember = "Title";
            PopulateRecents();
        }

        private void listBox_News_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_News.SelectedItem is NewsItem item)
            {
                LogRecent(item);
                PopulateRecents();
                ArticleDescription descriptionWindow = new ArticleDescription(item);
                descriptionWindow.Visible = true;
            }
        }

        private void LogRecent(NewsItem item)
        {
            if (!File.Exists(recentsFilePath))
            {
                File.Create(recentsFilePath).Close();
            }

            string output = item.Title + "|" + item.Link + "|" + item.Description;
            File.AppendAllText(recentsFilePath, output + "\n");
        }

        private void PopulateRecents()
        {
            if (!File.Exists(recentsFilePath))
            {
                File.Create(recentsFilePath).Close();
                return;
            }

            string[] rawRecents = File.ReadAllLines(recentsFilePath);
            for (int i = 0; i < rawRecents.Length; i++)
            {
                string[] s = rawRecents[i].Split("|");
                RecentNewsItem r = new RecentNewsItem
                {
                    Title = s[0],
                    Link = s[1],
                    Description = s[2]
                };

                recents.Add(r);
            }
            this.listBox_Recents.DataSource = null;
            this.listBox_Recents.DataSource = recents;
            this.listBox_Recents.DisplayMember = "Title";
        }

        private void listBox_Recents_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_News.SelectedItem is RecentNewsItem item)
            {
                ArticleDescription descriptionWindow = new ArticleDescription(item);
                descriptionWindow.Visible = true;
            }
        }
    }
}
