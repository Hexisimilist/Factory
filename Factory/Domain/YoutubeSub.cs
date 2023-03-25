using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Domain
{
    internal class YoutubeSub : ISubscription
    {


        private readonly string _name;
        private readonly decimal _price;

        public YoutubeSub(decimal price)
        {
            _name = "Youtube";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;

    }
}
