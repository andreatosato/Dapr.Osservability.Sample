using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Osservability.ReaderSecondary.Data.Models
{

    [Table("Vegetables")]
    public class VegetableEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Temperature { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
