using System;
using System.Windows.Forms;

namespace HttpServerApp
{
    public partial class FormServer : Form
    {
        private Host host;
        public FormServer()
        {
            InitializeComponent();
        }

        private async void buttonStartListener_Click(object sender, EventArgs e)
        {
            progressBarListener.Visible = true;
            textBoxLogger.Text = string.Empty;
            host = new Host(new WindowsFormsLogger(textBoxLogger), new string[] { "/hello", "/time", "/redirectToGoogle"});
            DisplayAvailablePaths();
            await host.ListenAsync();
        }

        private void DisplayAvailablePaths()
        {
            listBoxAvailablePaths.DataSource = host.Paths;
        }

        private void buttonStopListener_Click(object sender, EventArgs e)
        {
            host.Stop();
            progressBarListener.Visible = false;
        }
    }
}
