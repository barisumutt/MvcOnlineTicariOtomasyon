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

        [HttpGet]
        public ActionResult KategoriEkle()
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult KategoriEkle(Kategori k)
        {
            TicariOtomasyonDb.Add(k);
            TicariOtomasyonDb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var ktg = TicariOtomasyonDb.Kategoris.Find(id);
            TicariOtomasyonDb.Remove(ktg);
            TicariOtomasyonDb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = TicariOtomasyonDb.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }

        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = TicariOtomasyonDb.Kategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            TicariOtomasyonDb.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}