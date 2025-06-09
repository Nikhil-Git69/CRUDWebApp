using System.ComponentModel.DataAnnotations;

namespace CRUDAPPMVC.Models
{
    public class AddCustomerViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
