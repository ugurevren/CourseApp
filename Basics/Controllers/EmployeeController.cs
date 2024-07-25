using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            var message = $"Hello from Employee Controller. {DateTime.Now.ToString()} ";
            return View("Index1",message);
        }
        public ViewResult Index2()
        {
            var messages = new List<string>
            {
                "Hello from Employee Controller",
                "Hello from Index2 Action Method",
                "Hello from Index2 Action Method of Employee Controller"
            };
            // You can provide the name of the view to be rendered
            // If you don't provide the name of the view, it will look for a view with the same name as the action method. For example, in this case, it will look for Index2.cshtml
            return View("Index", messages);
        }
        public ContentResult Index3()
        {
            return Content("Hello from Employee Controller");
        }
        // IActionResult is the base class for all action results
        // it can return any type of result whether it is a view, content, json, file, etc.
        public IActionResult Index4()
        {
            var list = new List<Employee>
            {
                new Employee { Id = 1, Name = "John", Department = "HR" },
                new Employee { Id = 2, Name = "Smith", Department = "IT" },
                new Employee { Id = 3, Name = "Mark", Department = "IT" }
            };
            return View("Index4", list);
        }
    }

}