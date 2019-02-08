using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        { 
            string ch = File.ReadAllText("numbers.txt");
            string[] n = ch.Split(' ');
            int[] a = new int[n.Length];
            string[] b = new string[n.Length];
            StreamWriter c = new StreamWriter("prime_numbers.txt", true);
            for (int i = 0; i < n.Length; i++) {
                a[i] = Convert.ToInt32(n[i]);
                if (prime(a[i]) != 0) { b[i] = Convert.ToString(a[i]);c.Write($"{b[i]} "); }
            }
            c.Close();
        }
        static int prime(int n)
        {
            for (int i = 2; i <= n / 2; i++) { if (n % i == 0) { return 0; } }
            //если число n имеет делители от 2 до n/2 то оно не является простым и функция возвращает 0
            //если же не имеет то функция возвращает это же число
            return n;
        }
    }
}

