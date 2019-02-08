using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo file = new DirectoryInfo(path);
            PrintInfo(file, 0);
        }

        private static void PrintInfo(FileSystemInfo file, int k)
        {
            Console.WriteLine(new string(' ', k) + file.Name);
            if (file.GetType() == typeof(DirectoryInfo))
            {
                var y = file as DirectoryInfo;
                foreach (var x in y.EnumerateFileSystemInfos())
                {
                    PrintInfo(x, k + 3);
                }
            }
        }
    }
}