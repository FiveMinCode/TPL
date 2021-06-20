using System;
using System.Threading;

namespace TPL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Clock();
            TPLImplementation.WorkWithImages();
        }

        /// <summary>
        /// real time dashboard that is constantly updating with milliseconds
        /// </summary>
        public static void Clock()
        {
            var cont = false;
            while (!cont)
            {
                Console.CursorLeft = 0;
                Console.Write(System.DateTime.Now.ToString("HH:mm:ss.fff"));
                Thread.Sleep(50);
            }
        }
    }
}
