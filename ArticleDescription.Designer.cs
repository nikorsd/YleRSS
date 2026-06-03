namespace YleRSS
{
    partial class ArticleDescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_OpenArticle = new Button();
            button_Close = new Button();
            richTextBox_Article = new RichTextBox();
            SuspendLayout();
            // 
            // button_OpenArticle
            // 
            button_OpenArticle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_OpenArticle.Location = new Point(12, 124);
            button_OpenArticle.Name = "button_OpenArticle";
            button_OpenArticle.Size = new Size(95, 23);
            button_OpenArticle.TabIndex = 3;
            button_OpenArticle.Text = "Open article";
            button_OpenArticle.UseVisualStyleBackColor = true;
            button_OpenArticle.Click += button_OpenArticle_Click;
            // 
            // button_Close
            // 
            button_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Close.Location = new Point(113, 124);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(101, 23);
            button_Close.TabIndex = 4;
            button_Close.Text = "Close";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // richTextBox_Article
            // 
            richTextBox_Article.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox_Article.BorderStyle = BorderStyle.None;
            richTextBox_Article.Location = new Point(7, 12);
            richTextBox_Article.Name = "richTextBox_Article";
            richTextBox_Article.ReadOnly = true;
            richTextBox_Article.Size = new Size(343, 106);
            richTextBox_Article.TabIndex = 5;
            richTextBox_Article.Text = "";
            // 
            // ArticleDescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 159);
            Controls.Add(richTextBox_Article);
            Controls.Add(button_Close);
            Controls.Add(button_OpenArticle);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(378, 198);
            Name = "ArticleDescription";
            Text = "Article Description";
            ResumeLayout(false);
        }

        #endregion
        private Button button_OpenArticle;
        private Button button_Close;
        private RichTextBox richTextBox_Article;
    }
}