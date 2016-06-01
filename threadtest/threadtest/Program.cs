using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The main thread started");

            Worker w = new Worker();

            Thread t1 = new Thread(w.work);
            t1.Start();
            Thread.Sleep(100);
            w.Stop();
            Console.WriteLine("The main thread finished");
            Console.ReadKey();
        }
    }
}
