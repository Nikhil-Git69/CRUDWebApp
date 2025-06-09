using System;
using System.ComponentModel.DataAnnotations;


using CRUDAPPMVC.Models;
namespace CRUDAPPMVC.Models;

public class Customer
{
    public Guid Id { get; set; }

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
