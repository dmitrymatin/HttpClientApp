using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClientApp
{
    public partial class FormApp : Form
    {
        private static HttpClient httpClient = new HttpClient();
        public FormApp()
        {
            InitializeComponent();
        }

        private async void buttonSubmitUrl_Click(object sender, EventArgs e)
        {
            var result = await httpClient.GetAsync(textBoxInput.Text);
            textBoxDefaultRequest.Text = httpClient.DefaultRequestHeaders.ToString();
            textBoxResponseHeaders.Text = result.ToString();
            string content = await result.Content.ReadAsStringAsync();
            textBoxResponseBody.Text = content;
            new Visualiser(content).Show();
        }
    }
}
