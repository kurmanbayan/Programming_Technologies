using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace example
{
    
    class Program
    {
        static void Main(string[] args)
        {
            dirTree(@"C:\Users\Lenovo\me");
        }
        static void dirTree (string path)
        {
            Stack<string> st = new Stack<string>();
            st.Push(path);
            while (st.Count>0)
            {
                string[] subDir = Directory.GetDirectories(st.Pop());
                foreach(string q in subDir)
                {
                    Console.WriteLine(q + ": " + Directory.GetFiles(q).Length);
                    st.Push(q);
                    Console.ReadLine();
                }
            }
        }
    }   
}