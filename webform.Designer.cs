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
            toolStripContainer1 = new ToolStripContainer();
            toolStrip1 = new ToolStrip();
            backButton = new ToolStripButton();
            reloadButton = new ToolStripButton();
            forwardButton = new ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webBrowser1
            // 
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Location = new Point(0, 0);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Size = new Size(800, 425);
            webBrowser1.TabIndex = 0;
            webBrowser1.Url = new Uri("about:blank", UriKind.Absolute);
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(webBrowser1);
            toolStripContainer1.ContentPanel.Size = new Size(800, 425);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { backButton, reloadButton, forwardButton });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(171, 25);
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
            Controls.Add(toolStripContainer1);
            Name = "webform";
            Text = "webform";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public WebBrowser webBrowser1;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton backButton;
        private ToolStripButton reloadButton;
        private ToolStripButton forwardButton;
    }
}