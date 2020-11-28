using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
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

            HttpResponseMessage response = null;

            try
            {
                response = await httpClient.SendAsync(reqMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name);
                return;
            }

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

            textBoxDefaultRequest.Text = reqMessage.ToString() + Environment.NewLine;
            textBoxDefaultRequest.Text += $"Заголовки: {reqMessage.Headers}";

            bool allowModifyingHeaders = checkBoxAllowAddingHeaders.Checked;
            if (allowModifyingHeaders)
            {
                reqMessage.Headers.UserAgent
                    .Add(new ProductInfoHeaderValue("Chrome", "86.0.4240.111"));
                reqMessage.Headers.From = "someone@vlsu.ru";
                reqMessage.Headers.AcceptLanguage.Add(new StringWithQualityHeaderValue("en-US"));

                textBoxModifiedRequest.Text = reqMessage.ToString() + Environment.NewLine;
                textBoxModifiedRequest.Text += $"Заголовки: {reqMessage.Headers}";
            }

            return reqMessage;
        }

        private void buttonVisualise_Click(object sender, EventArgs e)
        {
            new Visualiser(responseContent).Show();
        }
    }
}
