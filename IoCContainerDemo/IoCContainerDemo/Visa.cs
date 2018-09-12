namespace IoCContainerDemo
{
    public class Visa : ICreditCard
    {
        public object Charge()
        {
            return "Charging with the visa";
        }
    }
}