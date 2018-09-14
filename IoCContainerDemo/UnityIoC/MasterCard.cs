namespace UnityIoC
{
    public class MasterCard : ICreditCard
    {
        public int ChargeCount
        {
            get
            {
                return 0;
            }
        }

        public string Charge()
        {
           return "Swiping the Mastercard";
        }
    }
}