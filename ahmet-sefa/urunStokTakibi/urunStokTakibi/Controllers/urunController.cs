using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace urunStokTakibi.Controllers
{
    public class urunController : Controller
    {
        public IActionResult Listele()
        {
            return View(Models.urunVeri.urunler);
        }
        public IActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Yeni(Models.urun yeniUrun)
        {
            Models.urunVeri.urunler.Add(yeniUrun);
            return RedirectToAction("Listele");
            
        }
        public IActionResult Guncelle(int id)
        {
            var r = Models.urunVeri.urunler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }
        [HttpPost]
        public IActionResult Guncelle(Models.urun Urun)
        {
            var c = Models.urunVeri.urunler.FirstOrDefault(x => x.Id == Urun.Id);
            var r = Models.urunVeri.urunler.FirstOrDefault(x => x.Id == Urun.Id);
            r.Ad = Urun.Ad;
            r.urunRengi = Urun.urunRengi;
            r.ListeFiyatı = Urun.ListeFiyatı;
            r.stokAdeti = Urun.stokAdeti;

            Models.urunVeri.urunler.Remove(c);
            Models.urunVeri.urunler.Add(r);
            return RedirectToAction("Listele");
        }
        public IActionResult Detay(int id)
        {
            var r = Models.urunVeri.urunler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }
        
        public IActionResult Sil(int id)
        {
            var r = Models.urunVeri.urunler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }
        [HttpPost]
        public IActionResult Sil(Models.urun Urunler)
        {
            var r = Models.urunVeri.urunler.FirstOrDefault(x => x.Id == Urunler.Id);
            Models.urunVeri.urunler.Remove(r);
            return RedirectToAction("Listele");
        }
    }
}
