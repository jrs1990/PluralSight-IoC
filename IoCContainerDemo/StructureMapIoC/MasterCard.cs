namespace StructureMapIoC
{
    public class MasterCard : ICreditCard
    {
        public int ChargeCount { get; set; }
        

        public string Charge()
        {
            ChargeCount++;
           return "Swiping the Mastercard";
        }
    }
}