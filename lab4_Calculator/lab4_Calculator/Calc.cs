using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Calculator
{
    class Calc
    {
        public double first;
        public double second;
        public double result = 1;
        public string operation;

        public void Calculate()
        {
            switch (operation)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
                case "x^y":
                    for (int i=1; i<=second; i++)
                    {
                        result = result * first; 
                    }
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
