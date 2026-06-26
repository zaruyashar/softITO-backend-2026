using Dapper;
using DpperApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DpperApp.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View(Context.Listeleme<PersonelModel>("PersonelViewAll"));
        }


        public IActionResult EY(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PersonelNo", id);
                return View(Context.Listeleme<PersonelModel>("PersonelViewByNo", param).FirstOrDefault());
            }
        }


        [HttpPost]
        public IActionResult EY(PersonelModel personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PersonelNo", personel.PersonelNo);
            param.Add("@AdSoyadi", personel.AdSoyadi);
            param.Add("@Yas", personel.Yas);
            param.Add("@Telefon", personel.Telefon);
            param.Add("@Adres", personel.Adres);
            Context.ExecuteReturn("PersonelEY", param);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PersonelNo", id);
            Context.ExecuteReturn("PersonelSil", param);
            return RedirectToAction("Index");
        }
    }
}
