using DerivativeCalculatorService;
using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Type serviceType = typeof(Calculator);
            using (ServiceHost host = new ServiceHost(serviceType))
            {
                host.Open();
                Console.WriteLine("The derivatives calculator service is available.");
                Console.ReadKey(true);
            }
        }
    }
}
