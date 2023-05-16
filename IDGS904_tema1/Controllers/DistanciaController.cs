using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public RedirectToRouteResult Calcular(Distancia distancia)
        {
            
            TempData["res"] = distancia.Calcular().ToString();
            return RedirectToAction("Index");
        }
        public ViewResult Index(Distancia distancia)
        {

            string res = "";
            if (TempData.ContainsKey("res"))
            {
                res = TempData["res"] as string;
            }
            ViewBag.Res = res;
            return View();
        }
    }
}