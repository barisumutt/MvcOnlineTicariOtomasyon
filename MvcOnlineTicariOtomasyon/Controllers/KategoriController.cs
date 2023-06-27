using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        
        private readonly TicariOtomasyonDbContext TicariOtomasyonDb;


        public IActionResult Index()
        {
            return View();
        }
    }
}
