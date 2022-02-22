using System;

namespace SpecFlowCalculater
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
            // throw new NotImplementedException();
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }
    }
}
