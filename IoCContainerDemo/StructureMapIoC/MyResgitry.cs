using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Pipeline;
using StructureMap.Configuration;

namespace StructureMapIoC
{
    public class MyResgitry: Registry
    {
        public MyResgitry()
        {
            For<ICreditCard>().Singleton().Use<MasterCard>();
        }
    }
}
