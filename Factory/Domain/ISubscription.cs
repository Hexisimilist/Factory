namespace Factory.Domain
{
    internal interface ISubscription
    {
        string Name { get; }
        string Description { get; set; }

        decimal GetPrice();

    }
}
