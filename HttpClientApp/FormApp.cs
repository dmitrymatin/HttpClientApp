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
        private string responseContent = string.Empty;

        public FormApp()
        {
            InitializeComponent();
        }

        private async void buttonSubmitUrl_Click(object sender, EventArgs e)
        {
            HttpRequestMessage reqMessage = PrepareRequest();

            HttpResponseMessage response = await httpClient.SendAsync(reqMessage);

            CheckForErrors(response);

            await ProcessResponse(response);
        }

        private async Task ProcessResponse(HttpResponseMessage response)
        {
            textBoxResponseHeaders.Text = response.ToString();

            responseContent = await response.Content.ReadAsStringAsync();
            await File.WriteAllTextAsync($"response_content_{DateTime.UtcNow:dd-MM-yyyy-HH-mm-ss}.txt", responseContent);
            textBoxResponseBody.Text = responseContent;
        }

        private void CheckForErrors(HttpResponseMessage response)
        {
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                textBoxResponseErrors.Text = ex.Message;
            }
        }

        private HttpRequestMessage PrepareRequest()
        {
            HttpRequestMessage reqMessage = new HttpRequestMessage(new HttpMethod("GET"), textBoxInput.Text);
            reqMessage.Version = new Version(1, 1);

            string queryString = $"Строка запроса: Method: {reqMessage.Method}, RequestUri: {reqMessage.RequestUri}, "
                + $"Version: {reqMessage.Version}, Content: {reqMessage.Content?.ToString() ?? "<null>"}, "
                + $"Headers: {Environment.NewLine}{ParseRequestHeaders(reqMessage.Headers)}";

            textBoxDefaultRequest.Text = queryString;
            textBoxDefaultRequest.Text += $"Заголовки: {ParseRequestHeaders(reqMessage.Headers)}";

            bool allowModifyingHeaders = checkBoxAllowAddingHeaders.Checked;
            if (allowModifyingHeaders)
            {
                reqMessage.Headers.Add("Kek", "Lol");
                reqMessage.Headers.Add("K", "L");
                reqMessage.Headers.AcceptLanguage.Add(new StringWithQualityHeaderValue("en-US"));

                string modifiedQueryString = $"Строка запроса: Method: {reqMessage.Method}, RequestUri: {reqMessage.RequestUri}, "
                    + $"Version: {reqMessage.Version}, Content: {reqMessage.Content?.ToString() ?? "<null>"}, "
                    + $"Headers: {Environment.NewLine}{ParseRequestHeaders(reqMessage.Headers)}";

                textBoxModifiedRequest.Text = modifiedQueryString;
            }

            return reqMessage;
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

        private void buttonVisualise_Click(object sender, EventArgs e)
        {
            new Visualiser(responseContent).Show();
        }
    }
}
