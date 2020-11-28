using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HostingLib
{
    public class Host
    {
        private HttpListener httpListener;
        private string[] paths;
        private bool listen;
        private ILogger logger;

        public IList<string> Paths { get => httpListener.Prefixes.ToList(); }

        public Host(ILogger logger, string[] paths)
        {
            if (!HttpListener.IsSupported)
            {
                throw new Exception("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
            }

            httpListener = new HttpListener();

            this.paths = paths;

            InitialisePrefixes();

            this.logger = logger;
        }

        private void InitialisePrefixes()
        {
            foreach (var path in paths)
            {
                httpListener.Prefixes.Add("http://localhost:61363" + $"{path}/");
            }
        }

        public void Stop()
        {
            httpListener.Stop();
            listen = false;
        }

        public async Task ListenAsync()
        {
            httpListener.Start();
            listen = true;
            logger.Log("listening...");

            while (listen)
            {
                HttpListenerContext context = null;
                try
                {
                    context = await httpListener.GetContextAsync();
                }
                catch (HttpListenerException ex)
                {
                    if (ex.ErrorCode == 995) 
                        logger.Log("stopped listening (995).");
                    return;
                }

                HttpListenerRequest request = context.Request;

                logger.Log($"Incoming request to {request.Url}; {request.Headers}");

                HttpListenerResponse response = context.Response;
                byte[] buffer = PrepareResponseMessage(request, response);

                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                //// You must close the output stream.
                output.Close();
            }
        }

        private byte[] PrepareResponseMessage(HttpListenerRequest request, HttpListenerResponse response)
        {
            string responseString = string.Empty;

            switch (request.Url.AbsolutePath)
            {
                case "/hello":
                    responseString = $"<HTML><BODY> Hello {request.Headers["From"]}!</BODY></HTML>";
                    break;
                case "/time":
                    responseString = $"<HTML><BODY> It's {DateTimeOffset.UtcNow}!</BODY></HTML>";
                    break;
                case "/redirectToGoogle":
                    response.Redirect("https://google.com");
                    break;
                default:
                    break;
            }

            
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);
            return buffer;
        }
    }
}