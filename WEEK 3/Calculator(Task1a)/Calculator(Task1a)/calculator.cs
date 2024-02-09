using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Task1a_
{
    internal class calculator
    {   /*
        public calulator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }*/
        public int num1;
        public int num2;
        public char operation;
       
        public float Add()
        {
            return num1+ num2;
        }
        public float Multiply()
        {
            return num1* num2;
        }
        public float Division()
        {
            if(num1>num2)
            {
                return num1 / num2;
            }
            else
            {
                return num2 / num1;
            }
        }
        public float Subtraction()
        {
            if(num1>num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }

            

    }
}
