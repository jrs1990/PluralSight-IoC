using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectIoC
{
    class Shopper
    {
        private ICreditCard creditCard;
        public Shopper(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }
        

        public int ChargesForCurrentCard { get { return this.creditCard.ChargeCount; } }

        public void Charge()
        {
            var chargeMessage = this.creditCard.Charge();
            Console.WriteLine(chargeMessage);
        }
    }
}
