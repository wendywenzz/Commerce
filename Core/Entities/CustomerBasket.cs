using System.Collections.Generic;

namespace Core.Entities
{
    public class CustomerBasket
    {
        public CustomerBasket()
        {
        }

        public CustomerBasket(string id)
        {
            CustomerBasketId = id;
        }

        public string CustomerBasketId { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}