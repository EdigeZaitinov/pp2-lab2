using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        { 
            //записывание информации в первый файл
            string path = @"D:\pp2\lab2 c#\task4\task4\bin\Debug\input.txt";
            string path1 = @"D:\pp2\lab2 c#\task4\task4\bin\Debug\cop.txt";
            FileStream f = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter a = new StreamWriter(f);
            string n = Console.ReadLine();
            a.Write(n);
            a.Close();
            //копирование информации
            File.Copy(path, path1);
            File.Delete(path);
        }
    }
}
