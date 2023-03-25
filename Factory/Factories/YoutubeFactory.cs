using Factory.Domain;

namespace Factory.Factories
{
        internal class YoutubeFactory : GetSubFactory
        {
            private readonly decimal _price;
            private readonly string _description;

            public YoutubeFactory(decimal price, string description)
            {
                _price = price;
                _description = description;
            }

            public override ISubscription GetSubscription()
            {
                YoutubeSub sub = new(_price)
                {
                    Description = _description
                };

                return sub;
            }

        }
    

}