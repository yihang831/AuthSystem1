using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Controllers
{
    [Route("ErrorPage/{statusCode}")]
    public class ErrorPageController : Controller
    {
        public IActionResult Index(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewData["Error"] = "Sorry, the resource you requested could not be found";
                    break;
                default:
                    break;
            }
            return View("ErrorPage");
        }
    }
}
