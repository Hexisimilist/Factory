using Factory.Domain;

namespace Factory.Factories
{
    internal abstract class GetSubFactory
    {
        public abstract ISubscription GetSubscription();
    }
}
