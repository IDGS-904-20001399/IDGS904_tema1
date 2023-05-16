using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class ControladorNuevoController : Controller
    {
        // GET: ControladorNuevo
        public ActionResult Index()
        {
            ViewBag.Saludo = "Hola mundo desde controlador nuevo";
            return View();
        }

        public ActionResult Vista(string num1, string num2)
        {
            int res = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            ViewBag.Res = res.ToString();

            return View();
        }

        public ActionResult Calcular(OperasBas op)
        {
            var model = new OperasBas();
            model.Res = op.calcular();
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques = new ProductServices();
            var model = pulques.ObtenerProductos();
            return View(model);
        }
    }
}