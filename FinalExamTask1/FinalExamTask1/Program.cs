using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamTask1
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

            for (int i = 0; i < array.Length; i++)
            {
                int num = int.Parse(array[i]);
                if (num%2 == 0 && num%3 != 0)
                {
                    second.WriteLine(num + " ");
                }
            }
            
            second.Close();
            first.Close();
            input.Close();
            output.Close();
            Console.ReadKey();
        }
    }
}
