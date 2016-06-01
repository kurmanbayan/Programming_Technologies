using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadddd
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(func);
            Thread t2 = new Thread(func);

            t1.Name = "first thread";
            t2.Name = "second thread";

            t1.Start();
            t2.Start();
            t1.Join();
            Console.ReadKey();    
        }
        private static void func()
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " prints: " + i);
            }
            Thread.Sleep(1000);
        }
    }
}
