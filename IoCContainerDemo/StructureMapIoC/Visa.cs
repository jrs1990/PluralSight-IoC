namespace StructureMapIoC
{
    public class Visa : ICreditCard
    {
        public int ChargeCount { get { return 0; }}

        public string Charge()
        {
            return "Swiping the Visa";
        }
    }
}