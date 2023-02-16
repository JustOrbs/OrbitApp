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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}