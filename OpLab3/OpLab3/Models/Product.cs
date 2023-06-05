using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpLab3.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public uint Amount { get; set; }

        public void AddProducts(uint amount)
        {
            Amount += amount;
        }
    }
}
