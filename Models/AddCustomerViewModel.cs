using System.ComponentModel.DataAnnotations;

namespace CRUDAPPMVC.Models
{
    public class AddCustomerViewModel
    {
       
        public string Name { get; set; }

        public string Address { get; set; }


        public string Gender { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }
    }
}
