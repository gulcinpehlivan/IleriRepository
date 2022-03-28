using IleriRepository.Models.Data;
using IleriRepository.Models.ViewModel;
using IleriRepository.REPO.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IleriRepository.Controllers
{
    public class SehirController : Controller
    {
        // GET: Sehir
        SehirRep sehirRep = new SehirRep();
        public ActionResult List()
        {
            return View(sehirRep.SehirListe());
        }
        [HttpGet]
        public ActionResult Add()
        {
            SehirModel model = new SehirModel();
            model.Sehir = new Sehir();
            model.BtnClass = "btn btn-primary";
            model.BtnText = "Ekle";
            model.Header = "Yeni Kayıt";
            return View("Crud" , model);
        }
        [HttpPost]
        public ActionResult Add(SehirModel model)
        {
            sehirRep.Ekle(model.Sehir);
            sehirRep.Kaydet();
            return  RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            SehirModel model = new SehirModel();
            model.Sehir = sehirRep.Bul(id);
            model.BtnClass = "btn btn-success";
            model.BtnText = "Güncelle";
            model.Header = "Güncelleme İşlemi";
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Update(SehirModel model)
        {
            sehirRep.Guncel(model.Sehir);
            sehirRep.Kaydet();
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {
            SehirModel model = new SehirModel();
            model.Sehir = sehirRep.Bul(id);
            model.BtnClass = "btn btn-danger";
            model.BtnText = "Sil";
            model.Header = "Silme İşlemi";
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Delete(SehirModel model)
        {
            sehirRep.Sil(model.Sehir);
            sehirRep.Kaydet();
            return RedirectToAction("List");
        }

    }
}