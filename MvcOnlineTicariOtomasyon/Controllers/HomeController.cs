using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models;
using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System.Diagnostics;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


    }
}