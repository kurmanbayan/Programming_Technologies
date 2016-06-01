using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"C:\Users\Lenovo\me\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream output = new FileStream(@"C:\Users\Lenovo\me\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader first = new StreamReader(input);
            StreamWriter second = new StreamWriter(output);

            string[] array = first.ReadLine().Split();
            int mn = int.Parse(array[0]);
            int mx = int.Parse(array[0]);


            for (int i = 0; i < array.Length; i++)
            {
                int num = int.Parse(array[i]);
                if (mn>num)
                {
                    mn = num;
                }
                else
                if (mx < num)
                {
                    mx = num;
                }
            }
            second.WriteLine("Min number = {0}; Max number = {1}", mn, mx);
            first.Close();
            second.Close();
            input.Close();
            output.Close();
            Console.ReadKey();

        }
    }
}
