using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;


namespace CastleIoC
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = new WindsorContainer();

            container.Install(new ShopperInstaller());
            var shopper = container.Resolve<Shopper>();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);

            var shopper2 = container.Resolve<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCard);

            Console.ReadKey();
            
        }
    }
}
