using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep2
{
    class CalcComp
    {
        public double first;
        public double second;
        public double result;
        public string operation;

        public void Calculate()
        {
            switch(operation)
            {
                case "+":
                    result = first + second;
                break;
                case "/":
                    result = first / second;
                break;
                default:
                break;
            }
        }
        public double Result
        {
            get { return result; }
            set { result = value; }
        }
    }
}
