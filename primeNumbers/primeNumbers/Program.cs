using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[10001];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 2; j <= Math.Sqrt(a[i]); j++)
                {
                    if (a[i]%j==0 && a[i] != j)
                    {
                        a[i] = 0;
                        break;
                    }
                }
                if (a[i]!=0 && a[i]!=1)
                {
                    Console.WriteLine(" " + a[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
