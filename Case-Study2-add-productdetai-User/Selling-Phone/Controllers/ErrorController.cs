using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Selling_Phone.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{StatusCode}")]
        public IActionResult PageNotFound(int StatusCode)
        {
            ViewBag.ErrorMessage = $"Error {StatusCode}:Sorry the resource you resques could not be found";
            return View();
        }
        [Route("Error")]
        public ViewResult Error()
        {
            return View("Exception");
        }
    }
}
