using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpServerApp
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        private async void FormServer_Load(object sender, EventArgs e)
        {
            await InitialiseHttpListener();
        }

        private async Task InitialiseHttpListener()
        {
            if (!HttpListener.IsSupported)
            {
                Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
                return;
            }

            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:61363/request/");
            listener.Start();
            textBoxLogger.Text += $"{Environment.NewLine}listening...";

            HttpListenerContext context =  await listener.GetContextAsync();
            HttpListenerRequest request = context.Request;

            textBoxLogger.Text += $"{Environment.NewLine}incoming request to {request.Url}:: {request.Headers}";

            HttpListenerResponse response = context.Response;

            string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            // Get a response stream and write the response to it.
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            //// You must close the output stream.
            //output.Close();
            //listener.Stop();
        }
    }
}
