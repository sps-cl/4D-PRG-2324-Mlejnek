using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.operations;

namespace StrategyPattern.operations
{
    internal class OperationSub : IOperation
    {
        public int execute(int a, int b)
        {
            return a - b;
        }
    }
}
