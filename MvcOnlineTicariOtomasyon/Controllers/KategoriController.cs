using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        private readonly TicariOtomasyonDbContext _ticariOtomasyonDb;

        public KategoriController(TicariOtomasyonDbContext ticariOtomasyonDb)
        {
            _ticariOtomasyonDb = ticariOtomasyonDb;
        }

        public IActionResult Index()
        {
            List<Kategori> kategoriler = _ticariOtomasyonDb.Kategoris.ToList();
            return View(kategoriler);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(Kategori k)
        {
            _ticariOtomasyonDb.Kategoris.Add(k);
            _ticariOtomasyonDb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var ktg = _ticariOtomasyonDb.Kategoris.Find(id);
            _ticariOtomasyonDb.Kategoris.Remove(ktg);
            _ticariOtomasyonDb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = _ticariOtomasyonDb.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }

        [HttpPost]
        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = _ticariOtomasyonDb.Kategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            _ticariOtomasyonDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
