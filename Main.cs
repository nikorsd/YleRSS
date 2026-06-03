namespace YleRSS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.newsList.ToString);
        }

        private void newsList_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Hello YleRSS!");
            for (int i = 0; i < 10; i++)
            {
                this.newsList.Items.Add(i.ToString());
            }
        }
    }
}
