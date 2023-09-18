using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.operations
{
    internal class OperationMultiply : IOperation
    {
        public int execute(int a, int b) 
        {
            return a * b; 
        }
    }
}
