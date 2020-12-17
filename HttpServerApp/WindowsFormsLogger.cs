using System;
using System.Windows.Forms;
using HostingLib;

namespace HttpServerApp
{
    public class WindowsFormsLogger : ILogger
    {
        private TextBox textBox;
        public WindowsFormsLogger(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public void Log(string message)
        {
            textBox.Text += $"{Environment.NewLine}{message}";
        }
    }
}
