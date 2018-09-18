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
            var container = new Container();
            container.Configure(x => x.For<ICreditCard>().Use<MasterCard>());
            container.Configure(x => x.For<ICreditCard>().Use<Visa>().Named("visa"));


        }
    }
}
