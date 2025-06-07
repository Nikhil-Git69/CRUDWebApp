using CRUDAPPMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPPMVC.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options)
        {
                
        }
        public DbSet<Customer> Customers{ get; set; }

    }
}
