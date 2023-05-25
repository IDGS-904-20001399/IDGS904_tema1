using FirstApp.Models;
using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            var Alumno = new Alumnos
            {
                Nombre = "Roberto",
                Edad = 18,
                Activo = true,
                Inscrito = DateTime.Today,
            };
            ViewBag.Alumnos = Alumno;
            return View();
        }

        public  ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Convertir(Temp temp)
        {
            temp.CalculateCelcius();
            return View(temp);
        }

    }
}