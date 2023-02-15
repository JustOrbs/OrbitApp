using System.Net;
using System.Text;
using System.Threading;
namespace Orbit
{
    internal static class Program
    {
        static HttpListener _httpListener = new HttpListener();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //_httpListener.Prefixes.Add("http://localhost:5000/"); // add prefix "http://localhost:5000/"
            //_httpListener.Start(); // start server (Run application as Administrator!)
            //Console.WriteLine("Server started.");
            //Thread _responseThread = new Thread(ResponseThread);
            //_responseThread.Start(); // start the response thread
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        //static void ResponseThread()
        //{
        //    while (true)
        //    {
        //        HttpListenerContext context = _httpListener.GetContext(); // get a context
        //                                                                  // Now, you'll find the request URL in context.Request.Url
        //        byte[] _responseArray = Encoding.UTF8.GetBytes("<html><head><title>Localhost server -- port 5000</title></head>" +
        //        "<body>Welcome to the <strong>Localhost server</strong> -- <em>port 5000!</em></body></html>"); // get the bytes to response
        //        context.Response.OutputStream.Write(_responseArray, 0, _responseArray.Length); // write bytes to the output stream
        //        context.Response.KeepAlive = false; // set the KeepAlive bool to false
        //        context.Response.Close(); // close the connection
        //        Console.WriteLine("Respone given to a request.");
        //    }
        //}
    }
}