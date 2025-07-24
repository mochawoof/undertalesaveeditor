namespace undertalesaveeditor
{
    partial class webform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(webform));
            webBrowser1 = new WebBrowser();
            toolStrip1 = new ToolStrip();
            backButton = new ToolStripButton();
            reloadButton = new ToolStripButton();
            forwardButton = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webBrowser1
            // 
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Location = new Point(0, 25);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Size = new Size(800, 425);
            webBrowser1.TabIndex = 0;
            webBrowser1.Url = new Uri("about:blank", UriKind.Absolute);
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { backButton, reloadButton, forwardButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.ImageTransparentColor = Color.Magenta;
            backButton.Name = "backButton";
            backButton.Size = new Size(36, 22);
            backButton.Text = "Back";
            backButton.Click += backButton_Click;
            // 
            // reloadButton
            // 
            reloadButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            reloadButton.Image = (Image)resources.GetObject("reloadButton.Image");
            reloadButton.ImageTransparentColor = Color.Magenta;
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(47, 22);
            reloadButton.Text = "Reload";
            reloadButton.Click += reloadButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            forwardButton.Image = (Image)resources.GetObject("forwardButton.Image");
            forwardButton.ImageTransparentColor = Color.Magenta;
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(54, 22);
            forwardButton.Text = "Forward";
            forwardButton.Click += forwardButton_Click;
            // 
            // webform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webBrowser1);
            Controls.Add(toolStrip1);
            Name = "webform";
            Text = "webform";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public WebBrowser webBrowser1;
        private ToolStrip toolStrip1;
        private ToolStripButton backButton;
        private ToolStripButton reloadButton;
        private ToolStripButton forwardButton;
    }
}