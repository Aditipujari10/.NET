// using Microsoft.AspNetCore.Mvc;

// public class studentController : controller
// {
//     public IActionResult Index()
//     {
//         return view();
//     }
// }

using Microsoft.AspNetCore.Mvc;

namespace mvc_architech.Models
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}