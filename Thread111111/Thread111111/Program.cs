using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread111111
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(func);
            Thread thread2 = new Thread(func);
            thread1.Name = "firstThread";
            thread2.Name = "secondThread";
            thread1.Start();
            thread1.Join();
            thread2.Start();
            Console.ReadKey();
        }
        public static void func()
        {
            for (int i=1; i<=20; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " is: " + i);
            }
            Thread.Sleep(1000);
        }
    }
}
