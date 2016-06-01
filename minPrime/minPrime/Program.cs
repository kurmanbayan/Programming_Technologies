using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace minPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"C:\Users\Lenovo\me\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream output = new FileStream(@"C:\Users\Lenovo\me\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader first = new StreamReader(input);
            StreamWriter second = new StreamWriter(output);

            string[] s = first.ReadLine().Split();
            int[] a = new int[1000001];
            for (int i = 0; i < s.Length; i++)
            {
                 a[i] = int.Parse(s[i]);
            }
            int mn = a[0];
            for (int i = 0; i < s.Length; i++)
            {
                    for (int j = 2; j <= Math.Sqrt(a[i]); j++)
                {
                    if (a[i] % j == 0 && a[i] != j)
                    {
                        a[i] = 0;
                        break;
                    }
                }
                if (a[i] != 0 && a[i] != 1 && mn > a[i])
                {
                    mn = a[i];
                }
            }
            //Console.WriteLine(mn);
            second.WriteLine(mn);
            input.Close();
            
            second.Close();
            output.Close();
            first.Close();
            Console.ReadKey();
        }
    }
}
