using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = File.ReadAllText("text.txt");
            if (Pal(n) == true) { Console.Write("Yes"); }
            else { Console.Write("No"); }
        }
        static bool Pal(string n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] != n[n.Length-i- 1]) { return false; }
            }
             return true ; 
        }
    }
}
