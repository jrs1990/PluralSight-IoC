namespace StructureMapIoC
{
    public interface ICreditCard
    {
        int ChargeCount { get; }

        string Charge();
    }
}