using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design.Serialization;

namespace PortfolioCore.Controllers
{
    public class TestController : Controller
    {
        //[Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
