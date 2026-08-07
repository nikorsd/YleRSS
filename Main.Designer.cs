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
            listBox_Recents = new ListBox();
            label_Headlines = new Label();
            label_RecentlyRead = new Label();
            SuspendLayout();
            // 
            // listBox_News
            // 
            listBox_News.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_News.BorderStyle = BorderStyle.FixedSingle;
            listBox_News.FormattingEnabled = true;
            listBox_News.Location = new Point(12, 37);
            listBox_News.Name = "listBox_News";
            listBox_News.Size = new Size(330, 167);
            listBox_News.TabIndex = 2;
            listBox_News.MouseClick += listBox_News_MouseClick;
            // 
            // listBox_Recents
            // 
            listBox_Recents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_Recents.BorderStyle = BorderStyle.FixedSingle;
            listBox_Recents.FormattingEnabled = true;
            listBox_Recents.Location = new Point(12, 246);
            listBox_Recents.Name = "listBox_Recents";
            listBox_Recents.Size = new Size(330, 182);
            listBox_Recents.TabIndex = 3;
            listBox_Recents.MouseClick += listBox_Recents_MouseClick;
            // 
            // label_Headlines
            // 
            label_Headlines.AutoSize = true;
            label_Headlines.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Headlines.Location = new Point(12, 9);
            label_Headlines.Name = "label_Headlines";
            label_Headlines.Size = new Size(99, 25);
            label_Headlines.TabIndex = 4;
            label_Headlines.Text = "Headlines";
            // 
            // label_RecentlyRead
            // 
            label_RecentlyRead.AutoSize = true;
            label_RecentlyRead.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_RecentlyRead.Location = new Point(12, 216);
            label_RecentlyRead.Name = "label_RecentlyRead";
            label_RecentlyRead.Size = new Size(136, 25);
            label_RecentlyRead.TabIndex = 5;
            label_RecentlyRead.Text = "Recently Read";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 451);
            Controls.Add(label_RecentlyRead);
            Controls.Add(label_Headlines);
            Controls.Add(listBox_Recents);
            Controls.Add(listBox_News);
            MaximizeBox = false;
            MinimumSize = new Size(0, 490);
            Name = "Main";
            Text = "YleRSS - News";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox_News;
        private ListBox listBox_Recents;
        private Label label_Headlines;
        private Label label_RecentlyRead;
    }
}
