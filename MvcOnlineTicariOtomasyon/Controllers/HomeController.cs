using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models;
using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System.Diagnostics;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class HomeController : Controller
    {
        private readonly TicariOtomasyonDbContext TicariOtomasyonDb;
        private readonly ILogger<HomeController> _logger;


        public HomeController(TicariOtomasyonDbContext ticariOtomasyonDb)
        {
            TicariOtomasyonDb = ticariOtomasyonDb;
        }

        public IActionResult Index()
        {
            var degerler = TicariOtomasyonDb.Kategoris.ToList();
            return View(degerler);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}