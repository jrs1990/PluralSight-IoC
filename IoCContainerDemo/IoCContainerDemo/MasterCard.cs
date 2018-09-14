namespace IoCContainerDemo
{
    public class MasterCard : ICreditCard
    {
        public object Charge()
        {
            return "Swiping the Mastercard";
        }
    }
}