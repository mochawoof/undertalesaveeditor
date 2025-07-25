﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace undertalesaveeditor
{
    public partial class webform : Form
    {
        public webform(string url)
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(url, UriKind.RelativeOrAbsolute);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
