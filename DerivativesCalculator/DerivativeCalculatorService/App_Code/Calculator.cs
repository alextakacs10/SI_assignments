using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivativeCalculatorService
{
    public class Calculator : IDerivativesCalculator
    {
        #region IDerivativesCalculator Members
        public decimal CalculateDerivative(int days, string[] symbols, string[] functions)
        {
            return DateTime.Now.Millisecond;
        }
        #endregion
    }
}
