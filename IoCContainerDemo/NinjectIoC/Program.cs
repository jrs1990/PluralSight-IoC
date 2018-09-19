using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace NinjectIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<ICreditCard>().To<MasterCard>().InSingletonScope();

            var shopper = kernel.Get<Shopper>();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);   
            
            var shopper2 = kernel.Get<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCard);

            Console.Read();
        }
    }
}
