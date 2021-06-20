using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    public static class TPLImplementation
    {
        static Task<byte[]> GetData(string val) {
            byte[] buffer = new byte[4096];
            return Task.FromResult(buffer);
        }

        static Task<byte[]> ParseData(string val) {
            byte[] buffer = new byte[4096];
            return Task.FromResult(buffer);
        }

        static Task SaveData(byte[] val1, string val2) 
        { 
            return Task.FromResult(1+1); 
        }

        public static void WorkWithImages()
        {
            bool cont = true;
            var val = "Original Data";
            GetData(val).ContinueWith(task1 =>
            {
                var originalData = task1.Result;
                var parsedData = "Parsed Data";
                SaveData(originalData, parsedData).ContinueWith(task2 =>
                {
                    ParseData(parsedData).ContinueWith(task3 =>
                    {
                        var data = task3.Result;
                        SaveData(data, parsedData).ContinueWith(task4 =>
                        {
                            cont = true;
                        });
                    });
                });
            });

            while (cont) { }

            Console.WriteLine("Done!");
        }
    }
}
