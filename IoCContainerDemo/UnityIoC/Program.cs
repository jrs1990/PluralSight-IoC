using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices;
using Unity;
using Unity.Injection;
using Unity.Resolution;

namespace UnityIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ICreditCard, MasterCard>();
             container.RegisterType<ICreditCard, MasterCard>(new InjectionProperty("ChargeCount", 5));

            //var shopper = container.Resolve<Shopper>();
            var shopper = container.Resolve<Shopper>(new ParameterOverride("teste", new Visa()));
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);

            Console.ReadKey();
        

        }
    }
}
