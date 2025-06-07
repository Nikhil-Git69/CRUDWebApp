using CRUDAPPMVC.Data;
using CRUDAPPMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPPMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDBContext dBContext;

        public CustomerController(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }



        [HttpPost]

        public async Task<IActionResult> Add(AddCustomerViewModel viewModel)
        {

            var customer = new Customer
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Gender = viewModel.Gender,
                Address = viewModel.Address,
                Mobile = viewModel.Mobile,

            };

            await dBContext.Customers.AddAsync(customer);

            await dBContext.SaveChangesAsync();


            return RedirectToAction("List", "Customer");

        }



        [HttpGet]

        public async Task<IActionResult> List()
        {
            var customers = await dBContext.Customers.ToListAsync();
            return View(customers);
        }


        [HttpGet]

        public async Task<IActionResult> Edit(Guid id)
        {
            var customer = await dBContext.Customers.FindAsync(id);
            return View(customer);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Customer viewModel)
        {
          var customer =  await dBContext.Customers.FindAsync(viewModel.Id);

            if (customer != null)
            {
                customer.Name = viewModel.Name;
                customer.Email = viewModel.Email;
                customer.Gender = viewModel.Gender;
                customer.Address = viewModel.Address;
                customer.Mobile = viewModel.Mobile;

                await dBContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Customer");
        }


        [HttpPost]

        public async Task<IActionResult> Delete(Guid Id)
        {
            var customer = await dBContext.Customers.FindAsync(Id);

            if (customer  != null)
            {
                dBContext.Customers.Remove(customer);
                await dBContext.SaveChangesAsync();

            }

            return RedirectToAction("List", "Customer");
        }
    }
}
