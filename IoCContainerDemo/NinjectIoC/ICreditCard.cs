namespace NinjectIoC
{
    public interface ICreditCard
    {
        int ChargeCount { get; }

        string Charge();
    }
}