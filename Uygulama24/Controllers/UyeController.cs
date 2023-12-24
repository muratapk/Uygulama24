using Microsoft.AspNetCore.Mvc;
using Uygulama24.Models;

namespace Uygulama24.Controllers
{
    public class UyeController : Controller
    {
        List<Uyelerim> datam = new List<Uyelerim>() {
         new Uyelerim{ Id=1,kul="Kadir",sifre="123"},
         new Uyelerim{ Id=2,kul="Amine",sifre="123"},
         new Uyelerim{ Id=3,kul="Selen",sifre="123"},
         new Uyelerim{ Id=4,kul="Abdullah",sifre="123"},
         new Uyelerim{ Id=5,kul="Hakkı",sifre="123"},
        };
        public IActionResult Index()
        {
            var listem = datam.ToList();
            return View(listem);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string kul, string sifre)
        {
            if(kul=="Admin" && sifre=="1234")
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Error"] = "Kullanıcı veya Şifre Hatalı";
            }
            return View();
        }
        [HttpGet]
        public IActionResult Goster(int Id)
        {
            ViewBag.Deger = Id;
            return View();
        }
    }
}
