using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpLab3.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Guid id;
        private string? fullName;
        private string? email;

        public Guid Id { get => id; set => id = value; }
        public string? FullName { get => fullName; set => fullName = value; }
        public string? Email { get => email; set => email = value; }

        public bool ValidateEmail()
        {
            return Email != null;
        }

        public void OutputData()
        {
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
