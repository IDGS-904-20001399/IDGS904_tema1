using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Index()
        {
            if (TempData.ContainsKey("palabras"))
            {
                ViewBag.Palabras = TempData["palabras"] as List<AgregarTraductor>;
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(AgregarTraductor agregar)
        {
            var ope1 = new GuardarServices();
            ope1.GuardarArchivo(agregar);
            return View();
        }
        public RedirectToRouteResult Mostrar()
        {
            var palabras = new LeerService().LeerArchivo();
            TempData["palabras"] = palabras;
            return RedirectToAction("Index");
        }

        public ActionResult Traducir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Traducir(Traducir traducir)
        {
            ViewBag.Traduccion = traducir.TraducirPalabra();
            return View();
        }
    }
}