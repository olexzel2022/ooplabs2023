using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpLab3.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }
        public Status Status { get; set; }
        public List<Product>? Products { get; set; }
        public float OrderPrice { get; set; }
        public User? User { get; set; }

        public Status SetStatus()
        {
            if (User is null || Products is null)
            {
                Status = Status.Rejected;
            }
            else
            {
                Status = Status.Pending;
            }
            return Status;
        }
    }

    public enum Status
    {
        Shipped, Pending, Rejected
    }
}
