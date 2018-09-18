namespace CastleIoC
{
    public interface ICreditCard
    {
        int ChargeCount { get; }

        string Charge();
    }
}