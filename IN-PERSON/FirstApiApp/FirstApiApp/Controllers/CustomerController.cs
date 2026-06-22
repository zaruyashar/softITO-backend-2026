using FirstApiApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext context;

        // Ctor yazıp tap'e basınca otomatik geldi, parametrelerini ekledim
        public CustomerController(AppDbContext context)
        {
            this.context = context;
        }

        // Listing
        [HttpGet]
        [Route("GetCustomer")]
        public async Task<IEnumerable<Customer>> GetCustomer()
        {
            return await context.Customers.ToListAsync(); 
        }

        // Add/create
        [HttpPost]
        [Route("GetCustomer")]
        public async Task<Customer> AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        // Update
        [HttpPut]
        [Route("UpdateCustomer/{id}")]
        public async Task<Customer> UpdateCustomer(Customer customer, int id)
        {
            context.Entry(customer).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return customer;
        }

        // Delete
        [HttpDelete]
        [Route("DeleteCustomer/{id}")]
        public bool DeleteCustomer(int id)
        {
            bool a = false;
            var customer = context.Customers.Find(id);

            if (customer != null)
            {
                a = true;
                context.Entry(customer).State = EntityState.Deleted;
                context.SaveChangesAsync();
            }
            else
            {
                a = false;
            }
            return a;
        }

    }
}
