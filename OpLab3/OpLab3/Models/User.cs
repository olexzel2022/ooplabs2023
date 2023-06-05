using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpLab3.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? FUllName { get; set; }
        public string? Email { get; set; }

        public bool ValidateEmail()
        {
            return Email != null;
        }
    }
}
