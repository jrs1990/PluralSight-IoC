using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainerDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
 
            Resolver resolver = new Resolver();

            resolver.Register<ICreditCard, Visa>();
            resolver.Register<Shopper, Shopper>();
            

            var shopper = resolver.Resolve<Shopper>();
            shopper.Charge();
            
            Console.ReadKey();
            
        }
    }
}
