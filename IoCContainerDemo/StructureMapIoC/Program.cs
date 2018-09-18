using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace StructureMapIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(new MyResgitry());
            
                        
            var shopper = container.GetInstance<Shopper>();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);

            var shopper2 = container.GetInstance<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCard);

            Console.Read();


        }
    }
}
