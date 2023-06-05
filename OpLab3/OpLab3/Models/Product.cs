using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpLab3.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Guid? id;
        private string? name;
        private float price;
        private uint amount;

        public Guid? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public uint Amount { get => amount; set => amount = value; }

        public void AddProducts(uint amount)
        {
            Amount += amount;
        }
    }
}
