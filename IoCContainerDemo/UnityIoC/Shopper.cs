using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIoC
{
    class Shopper
    {
        private readonly ICreditCard creditCard;
        private int _ChargeCount;

        public int ChargeCount
        {
            get
            {
                return _ChargeCount;
            }
            set
            {
                _ChargeCount = value;
            }
        }
        public int ChargesForCurrentCard { get { return this.ChargeCount; } }

        public Shopper (ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public void Charge()
        {
            var chargeMessage = creditCard.Charge();
            ChargeCount++;
            Console.WriteLine(chargeMessage);
        }
    }
}
