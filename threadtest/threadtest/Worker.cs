using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadtest
{
    class Worker
    {
        public bool shouldWork = true;

        public void work()
        {
            int i = 0;
            while (shouldWork)
            {
                Console.WriteLine("Class worker working... " + i++);
            }
        }

        public void Stop()
        {
            this.shouldWork = false;
        }
    }
}
