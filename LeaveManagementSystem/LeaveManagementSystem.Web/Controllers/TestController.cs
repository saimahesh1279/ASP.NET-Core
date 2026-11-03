using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "student of MVC Master",
                DateofBirth = new DateTime(1998, 6, 28)
            };

            return View(data);
        }
    }
}
