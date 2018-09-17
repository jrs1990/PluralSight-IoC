using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleIoC
{
    class Shopper
    {
        public ICreditCard CreditCard { get; set; }

        public int ChargesForCurrentCard { get { return CreditCard.ChargeCount; } }

        public void Charge()
        {
            var chargeMessage = CreditCard.Charge();
            Console.WriteLine(chargeMessage);
        }
    }
}
