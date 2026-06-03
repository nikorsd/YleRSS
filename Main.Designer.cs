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
            label_Debug = new Label();
            listBox_News = new ListBox();
            SuspendLayout();
            // 
            // label_Debug
            // 
            label_Debug.AutoSize = true;
            label_Debug.Location = new Point(25, 416);
            label_Debug.Name = "label_Debug";
            label_Debug.Size = new Size(73, 15);
            label_Debug.TabIndex = 1;
            label_Debug.Text = "Debug Label";
            // 
            // listBox_News
            // 
            listBox_News.FormattingEnabled = true;
            listBox_News.Location = new Point(12, 12);
            listBox_News.Name = "listBox_News";
            listBox_News.Size = new Size(366, 394);
            listBox_News.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 450);
            Controls.Add(listBox_News);
            Controls.Add(label_Debug);
            MaximizeBox = false;
            MaximumSize = new Size(406, 489);
            MinimumSize = new Size(406, 489);
            Name = "Main";
            Text = "YleRSS - News";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Debug;
        private ListBox listBox_News;
    }
}
