using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HttpClientApp
{
    public partial class Visualiser : Form
    {
        private string content;
        public Visualiser(string content)
        {
            InitializeComponent();
            this.content = content;
        }

        private async void Visualiser_Load(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.NavigateToString(content);
        }
    }
}
