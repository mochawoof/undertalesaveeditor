namespace undertalesaveeditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            reloadToolStripButton = new ToolStripButton();
            openFolderToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            searchButton = new ToolStripButton();
            searchBox = new ToolStripTextBox();
            toolStripSplitButton1 = new ToolStripSplitButton();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            flagsToolStripMenuItem = new ToolStripMenuItem();
            battlesToolStripMenuItem = new ToolStripMenuItem();
            saveStructureToolStripMenuItem = new ToolStripMenuItem();
            monstersToolStripMenuItem = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            papyrusAndUndyneCallsToolStripMenuItem = new ToolStripMenuItem();
            funEventsToolStripMenuItem = new ToolStripMenuItem();
            debugModeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, reloadToolStripButton, openFolderToolStripButton, toolStripSeparator1, helpToolStripButton, searchButton, searchBox, toolStripSplitButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(684, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "&Open";
            openToolStripButton.Click += openToolStripButton_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += saveToolStripButton_Click;
            // 
            // reloadToolStripButton
            // 
            reloadToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            reloadToolStripButton.Image = (Image)resources.GetObject("reloadToolStripButton.Image");
            reloadToolStripButton.ImageTransparentColor = Color.Magenta;
            reloadToolStripButton.Name = "reloadToolStripButton";
            reloadToolStripButton.Size = new Size(47, 22);
            reloadToolStripButton.Text = "Reload";
            reloadToolStripButton.Click += reloadToolStripButton_Click;
            // 
            // openFolderToolStripButton
            // 
            openFolderToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openFolderToolStripButton.Image = (Image)resources.GetObject("openFolderToolStripButton.Image");
            openFolderToolStripButton.ImageTransparentColor = Color.Magenta;
            openFolderToolStripButton.Name = "openFolderToolStripButton";
            openFolderToolStripButton.Size = new Size(76, 22);
            openFolderToolStripButton.Text = "Open Folder";
            openFolderToolStripButton.Click += openFolderToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "He&lp";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // searchButton
            // 
            searchButton.Alignment = ToolStripItemAlignment.Right;
            searchButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.ImageTransparentColor = Color.Magenta;
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(46, 22);
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Alignment = ToolStripItemAlignment.Right;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(300, 25);
            searchBox.Text = "Name";
            searchBox.Enter += searchBox_Enter;
            searchBox.Leave += searchBox_Leave;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { roomsToolStripMenuItem, flagsToolStripMenuItem, battlesToolStripMenuItem, saveStructureToolStripMenuItem, monstersToolStripMenuItem, itemsToolStripMenuItem, papyrusAndUndyneCallsToolStripMenuItem, funEventsToolStripMenuItem, debugModeToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(75, 22);
            toolStripSplitButton1.Text = "Reference";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(211, 22);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // flagsToolStripMenuItem
            // 
            flagsToolStripMenuItem.Name = "flagsToolStripMenuItem";
            flagsToolStripMenuItem.Size = new Size(211, 22);
            flagsToolStripMenuItem.Text = "Flags";
            flagsToolStripMenuItem.Click += flagsToolStripMenuItem_Click;
            // 
            // battlesToolStripMenuItem
            // 
            battlesToolStripMenuItem.Name = "battlesToolStripMenuItem";
            battlesToolStripMenuItem.Size = new Size(211, 22);
            battlesToolStripMenuItem.Text = "Battles";
            battlesToolStripMenuItem.Click += battlesToolStripMenuItem_Click;
            // 
            // saveStructureToolStripMenuItem
            // 
            saveStructureToolStripMenuItem.Name = "saveStructureToolStripMenuItem";
            saveStructureToolStripMenuItem.Size = new Size(211, 22);
            saveStructureToolStripMenuItem.Text = "Save Structure";
            saveStructureToolStripMenuItem.Click += saveStructureToolStripMenuItem_Click;
            // 
            // monstersToolStripMenuItem
            // 
            monstersToolStripMenuItem.Name = "monstersToolStripMenuItem";
            monstersToolStripMenuItem.Size = new Size(211, 22);
            monstersToolStripMenuItem.Text = "Monsters";
            monstersToolStripMenuItem.Click += monstersToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(211, 22);
            itemsToolStripMenuItem.Text = "Items";
            itemsToolStripMenuItem.Click += itemsToolStripMenuItem_Click;
            // 
            // papyrusAndUndyneCallsToolStripMenuItem
            // 
            papyrusAndUndyneCallsToolStripMenuItem.Name = "papyrusAndUndyneCallsToolStripMenuItem";
            papyrusAndUndyneCallsToolStripMenuItem.Size = new Size(211, 22);
            papyrusAndUndyneCallsToolStripMenuItem.Text = "Papyrus and Undyne Calls";
            papyrusAndUndyneCallsToolStripMenuItem.Click += papyrusAndUndyneCallsToolStripMenuItem_Click;
            // 
            // funEventsToolStripMenuItem
            // 
            funEventsToolStripMenuItem.Name = "funEventsToolStripMenuItem";
            funEventsToolStripMenuItem.Size = new Size(211, 22);
            funEventsToolStripMenuItem.Text = "Fun Events";
            funEventsToolStripMenuItem.Click += funEventsToolStripMenuItem_Click;
            // 
            // debugModeToolStripMenuItem
            // 
            debugModeToolStripMenuItem.Name = "debugModeToolStripMenuItem";
            debugModeToolStripMenuItem.Size = new Size(211, 22);
            debugModeToolStripMenuItem.Text = "Debug Mode";
            debugModeToolStripMenuItem.Click += debugModeToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 425);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(684, 0);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "file0";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "file0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "New - Undertale Save Editor";
            ResizeBegin += Form1_ResizeBegin;
            ResizeEnd += Form1_ResizeEnd;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton helpToolStripButton;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripTextBox searchBox;
        private ToolStripButton searchButton;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem flagsToolStripMenuItem;
        private ToolStripMenuItem battlesToolStripMenuItem;
        private ToolStripMenuItem saveStructureToolStripMenuItem;
        private ToolStripMenuItem monstersToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem papyrusAndUndyneCallsToolStripMenuItem;
        private ToolStripMenuItem funEventsToolStripMenuItem;
        private ToolStripMenuItem debugModeToolStripMenuItem;
        private ToolStripButton openFolderToolStripButton;
        private ToolStripButton reloadToolStripButton;
    }
}
