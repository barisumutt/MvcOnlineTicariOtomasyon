using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Siniflar;
namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        private readonly TicariOtomasyonDbContext TicariOtomasyonDb;

        public UrunController(TicariOtomasyonDbContext ticariOtomasyonDb)
        {
            TicariOtomasyonDb = ticariOtomasyonDb;
        }
        public IActionResult Index()
        {
            var urunler = TicariOtomasyonDb.Uruns
                .Include(x => x.Kategori) // Include the related table
                .Where(x => x.Durum == true)
                .ToList();
            return View(urunler);
        }

        [HttpGet]
        public ActionResult YeniUrun()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {
            TicariOtomasyonDb.Uruns.Add(p);
            TicariOtomasyonDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
