using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayet.Concrete;
namespace AspnetMvc.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        public ActionResult Index()
        {
            Context c = new Context();

            //Toplam kategori sayısı
            ViewBag.categoryCount = c.Categories.Count();

            //Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            ViewBag.headingCount = c.Headings.Where(x => x.CategoryID==5).Count();

            //Yazar adında 'a' harfi geçen yazar sayısı
            ViewBag.writersName = c.Writers.Where(x => x.WriterName.Contains("a")).Count();

            //En fazla başlığa sahip kategori adı
            var cateName = c.Headings.GroupBy(g => g.CategoryID).Where(w => w.Count() > 1).Select(s => new
            {
                s.FirstOrDefault().Category.CategoryName
            }).Distinct().FirstOrDefault().CategoryName;
            ViewBag.cateName = cateName;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
            var categoryStatus = c.Categories.Select(x => x.CategoryStatus).Count();
            var categoryStatusTrue = c.Categories.Where(x => x.CategoryStatus.ToString() == "true").Count();
            ViewBag.resultCat = categoryStatusTrue-(categoryStatus - categoryStatusTrue);
            
            return View();
        }
    }
}