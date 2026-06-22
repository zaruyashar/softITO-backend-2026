using CodeFirstJavaScriptApp.Data;
using CodeFirstJavaScriptApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstJavaScriptApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult EmployeeList()
        {
            var data = context.Employees.ToList();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult AddEmployee(Employee employee)
        {

            var emp = new Employee()
            {
                Name = employee.Name,
                City = employee.City,
                State = employee.State,
                Salary = employee.Salary


            };

            context.Employees.Add(emp);
            context.SaveChanges();
            return new JsonResult("Data Saved");


        }

        public JsonResult Edit(int id)
        {
            var data = context.Employees.Where(m => m.Id == id).SingleOrDefault();
            return new JsonResult(data);

        }
        [HttpPost]
        public JsonResult Update(Employee employee)
        {
            context.Update(employee);
            context.SaveChanges();
            return new JsonResult("Record Updated");
        }


        public JsonResult Delete(int id)
        {
            var data = context.Employees.Where(m => m.Id == id).SingleOrDefault();
            context.Employees.Remove(data);
            context.SaveChanges();
            return new JsonResult("Data Deleted");
        }

    }
}