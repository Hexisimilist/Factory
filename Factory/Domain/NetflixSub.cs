namespace Factory.Domain
{
    internal class NetflixSub: ISubscription
    {

        
        private readonly string _name;
        private readonly decimal _price;

        public NetflixSub(decimal price)
        {
            _name = "Netflix";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    
    }
}
