using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Container container = new Container(1, 1, false, "white");
            Container sensitiveContainer = new SensitiveContainer(2, 1, false, "white");
            Container refrigeratedContainer = new RefrigeratedContainer(3, 1, "white");
            Container tankContainer = new TankContainer(4, 1, "white");
        }
    }
}