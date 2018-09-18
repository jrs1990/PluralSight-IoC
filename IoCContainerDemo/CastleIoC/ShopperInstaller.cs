using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace CastleIoC
{
    internal class ShopperInstaller: IWindsorInstaller
    {
        public ShopperInstaller()
        {
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<Shopper>().LifeStyle.Transient);
            container.Register(Component.For<ICreditCard>().ImplementedBy<MasterCard>().LifeStyle.Transient);
        }
    }
}