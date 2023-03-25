using Factory.Domain;

namespace Factory.Factories
{
    internal class NetflixFactory : GetSubFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public  NetflixFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override ISubscription GetSubscription()
        {
            NetflixSub sub = new(_price)
            {
                Description = _description
            };

            return sub;
        }
    }
}
