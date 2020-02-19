using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CodeCoverageTestLibrary
{
    public class Operations : IOperations<float>
    {
        public float Add(float a, float b) { return a + b; }
        public float Subtract(float a, float b) { return a - b; }
        public float Multiply(float a, float b) { return a * b; }
        public float Divide(float a, float b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }
    }
}
