using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpLab3.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Guid? id;
        private Status status;
        private List<Product>? products;
        private float orderPrice;
        private User? user;

        public Guid? Id { get => id; set => id = value; }
        public Status Status { get => status; set => status = value; }
        public List<Product>? Products { get => products; set => products = value; }
        public float OrderPrice { get => orderPrice; set => orderPrice = value; }
        public User? User { get => user; set => user = value; }

        public Status SetStatus()
        {
            if (User is null || Products is null || OrderPrice <= 0)
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
