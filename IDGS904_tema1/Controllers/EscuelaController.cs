using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public JsonResult Index()
        {
            var pulque = new Productos()
            {
                Nombre = "Pulque 1",
                Descripcion = "Pulque de fresa",
                Cantidad = 10,
                Produccion = DateTime.Today
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult Vista()
        {
            return Redirect("https://google.com");
        }

        public RedirectToRouteResult Vista2()
        {
            TempData["nombre"] = "Roberto";
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS 904";
            ViewData["materia"] = "DWPI";
            string nombre = "";
            if (TempData.ContainsKey("nombre"))
            {
                nombre = TempData["nombre"] as string;
            }
            ViewBag.Valor = nombre;
            return View();
        }
    }
}