using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
