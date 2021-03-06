using System;

namespace Osservability.ReaderSecondary
{
    public class Vegetable
    {
        public DateTime ExpirationDate { get; set; }

        public decimal Temperature { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}
