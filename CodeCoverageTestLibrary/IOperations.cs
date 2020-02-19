using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCoverageTestLibrary
{
    public interface IOperations<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
    }
}
