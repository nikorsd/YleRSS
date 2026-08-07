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
            // Limit the max height
            this.MaximumSize = new Size(int.MaxValue, 490);

            using var client = new HttpClient();

            // YLE RSS returns 403 forbidden if we don't have a user agent, this was AI generated
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

            var xml = await client.GetStringAsync("https://yle.fi/rss/uutiset/paauutiset");
            var doc = XDocument.Parse(xml);

            // Parse
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
            List<string> lines = new List<string>();
            if (File.Exists(recentsFilePath))
            {
                lines.AddRange(File.ReadAllLines(recentsFilePath));
            }

            string output = item.Title + "|" + item.Link + "|" + item.Description;

            // Remove duplicate entries
            lines.RemoveAll(l => l == output);

            // Remove the oldest entry (first line) once at 50-line cap
            if (lines.Count >= 50)
            {
                lines.RemoveAt(0);
            }

            lines.Add(output);
            File.WriteAllLines(recentsFilePath, lines);
        }

        private void PopulateRecents()
        {
            // Create file if doesnt exist
            if (!File.Exists(recentsFilePath))
            {
                File.Create(recentsFilePath).Close();
                return;
            }

            string[] rawRecents = File.ReadAllLines(recentsFilePath);
            recents.Clear(); // Clear and repopulate so the order is newest to oldest
            for (int i = rawRecents.Length - 1; i >= 0; i--)
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
            if (listBox_Recents.SelectedItem is RecentNewsItem item)
            {
                ArticleDescription descriptionWindow = new ArticleDescription(item);
                descriptionWindow.Visible = true;
            }
        }
    }
}
