using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DerivativeCalculatorService
{
    [ServiceContract]
    public interface IDerivativesCalculator
    {
        [OperationContract]
        Decimal CalculateDerivative(int days, string[] symbols, string[] functions);
    }
}
