using System;

namespace Osservability.ReaderPrimary
{
    public class Fruit
    {
        public DateTime ExpirationDate { get; set; }

        public decimal Temperature { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}
