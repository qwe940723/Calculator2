using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Calculate2
    {
        public float firstNumber { get; set; } = 0;  
        public float secondNumber { get; set; } = 0; 

       
        public float Add()
        {
            return firstNumber + secondNumber;
        }

        
        public float Subtract()
        {
            return firstNumber - secondNumber;
        }

        
        public float Multiply()
        {
            return firstNumber * secondNumber;
        }

        
        public float Divide()
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return firstNumber / secondNumber;
        }

        
        public void Reset()
        {
            firstNumber = 0;
            secondNumber = 0;
        }
    }
}

