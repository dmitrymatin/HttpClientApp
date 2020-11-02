using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
            // prepare request
            HttpRequestMessage reqMessage = new HttpRequestMessage(new HttpMethod("GET"), textBoxInput.Text);
            reqMessage.Version = new Version(1, 1);

            reqMessage.Headers.Add("Kek", "Lol");
            reqMessage.Headers.Add("K", "L");

            string queryString = $"Строка запроса: Method: {reqMessage.Method}, RequestUri: {reqMessage.RequestUri}, "
                + $"Version: {reqMessage.Version}, Content: {reqMessage.Content?.ToString() ?? "<null>"}, "
                + $"Headers: {Environment.NewLine}{ParseRequestHeaders(reqMessage.Headers)}";
            
            textBoxDefaultRequest.Text = queryString;

            textBoxDefaultRequest.Text += $"Заголовки: {ParseRequestHeaders(httpClient.DefaultRequestHeaders)}";

            // send
            HttpResponseMessage response = await httpClient.SendAsync(reqMessage);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                textBoxResponseErrors.Text = ex.Message;
            }

            textBoxResponseHeaders.Text = response.ToString();

            string content = await response.Content.ReadAsStringAsync();
            var date = DateTime.UtcNow;
            await File.WriteAllTextAsync($"response_content_{date:dd-MM-yyyy-HH-mm-ss}.txt", content);
            textBoxResponseBody.Text = content;

            new Visualiser(content).Show();
        }

        private static string ParseRequestHeaders(HttpRequestHeaders headers)
        {
            StringBuilder stringBuilder = new StringBuilder($"{{{Environment.NewLine}");
            foreach (var item in headers)
            {
                stringBuilder.Append(item.Key).Append(" : ");
                foreach (var value in item.Value)
                {
                    stringBuilder.Append(value).Append(Environment.NewLine);
                }
            }
            stringBuilder.Append($"}}{Environment.NewLine}");
            return stringBuilder.ToString();
        }
    }
}
