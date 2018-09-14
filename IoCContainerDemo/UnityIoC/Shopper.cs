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
        public int ChargeCount
        {
            get
            {
                return 0;
            }
        }
        public int ChargesForCurrentCard { get;  set; }

        public Shopper (ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public void Charge()
        {
            var chargeMessage = creditCard.Charge();
            
            Console.WriteLine(chargeMessage);
        }
    }
}
