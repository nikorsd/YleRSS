namespace YleRSS
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_News = new ListBox();
            SuspendLayout();
            // 
            // listBox_News
            // 
            listBox_News.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_News.BorderStyle = BorderStyle.FixedSingle;
            listBox_News.FormattingEnabled = true;
            listBox_News.Location = new Point(12, 12);
            listBox_News.Name = "listBox_News";
            listBox_News.Size = new Size(366, 422);
            listBox_News.TabIndex = 2;
            listBox_News.MouseClick += listBox_News_MouseClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 450);
            Controls.Add(listBox_News);
            MaximizeBox = false;
            MinimumSize = new Size(406, 489);
            Name = "Main";
            Text = "YleRSS - News";
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox_News;
    }
}
