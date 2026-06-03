using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static YleRSS.Main;

namespace YleRSS
{
    public partial class ArticleDescription : Form
    {
        private NewsItem sharedItem;
        public ArticleDescription(NewsItem item)
        {
            sharedItem = item;
            InitializeComponent();
            Setup(item);
        }

        private void Setup(NewsItem item)
        {
            richTextBox_Article.Clear();

            // TITLE (bold)
            richTextBox_Article.SelectionFont =
                new Font(richTextBox_Article.Font.FontFamily, 11, FontStyle.Bold);

            richTextBox_Article.AppendText(item.Title + "\n");

            // DESCRIPTION (normal)
            richTextBox_Article.SelectionFont =
                new Font(richTextBox_Article.Font.FontFamily, 10, FontStyle.Regular);

            richTextBox_Article.AppendText(item.Description);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OpenArticle_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = sharedItem.Link,
                UseShellExecute = true
            });
        }
    }
}
