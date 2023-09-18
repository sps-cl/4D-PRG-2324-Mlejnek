using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.operations;

namespace StrategyPattern
{
    internal class CalculatorContext
    {
        private IOperation _operation;

        public CalculatorContext(IOperation operation) 
        {
            _operation = operation;
        }

        public int executeOperation(int a, int b)
        {
            return this._operation.execute(a, b);
        }
    }
}
