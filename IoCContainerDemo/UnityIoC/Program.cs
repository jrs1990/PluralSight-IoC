﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices;
using Unity;
using Unity.Injection;
using Unity.Resolution;
using Unity.Lifetime;
namespace UnityIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<ICreditCard, MasterCard>(new ContainerControlledLifetimeManager());

            var shopper = container.Resolve<Shopper>();
            shopper.Charge();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);

            var shopper2 = container.Resolve<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCard);

           

            Console.ReadKey();
        

        }
    }
}
