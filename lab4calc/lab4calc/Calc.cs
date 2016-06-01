using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4calc
{
    class Calc
    {
        public double first;
        public double second;
        public double result;
        public string operation;
            
        public void Calculate()
        {
            switch (operation)
            {
                case "+":
                    result = second + first;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "×":
                    result = first * second;
                    break;
                case "÷":
                    result = first / second;
                    break;
                case "x ^ y": 
                    result = Math.Pow(first, second); 
                    break;
                case "%":
                    result = (first / 100) * second;
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
