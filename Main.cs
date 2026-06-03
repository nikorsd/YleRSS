namespace YleRSS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void listBox_News_Enter(object sender, EventArgs e)
        {
            string[] news = {"Pena tappoin jarin", "Penan koulu paloi maahan", "Naapurin pertti söi multaa pihalla"};

            for (int i = 0; i < news.Length; ++i)
            {
                this.listBox_News.Items.Add(news[i]);
            }
        }
    }
}
