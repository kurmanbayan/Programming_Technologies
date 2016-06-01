using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"C:\Users\Lenovo\me\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream output = new FileStream(@"C:\Users\Lenovo\me\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader f = new StreamReader(input);
            StreamWriter s = new StreamWriter(output);

            string[] array = f.ReadLine().Split();
            int num;

            for (int i = 0; i < array.Length; i++)
            {
               num = int.Parse(array[i]);
               if (i % 2 != 0)
               {
                    s.WriteLine(num + "\n");
               }               
            }
            s.Close();
            f.Close();
            input.Close();
            output.Close();
            Console.ReadKey();
            
        }
    }
}
