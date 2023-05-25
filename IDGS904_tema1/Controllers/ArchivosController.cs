using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Maestros maestros)
        {
            var ope1 = new GuardarServices();
            //ope1.GuardarArchivo(maestros);
            return View();
        }
        public ActionResult LeerDatos()
        {
            var ope1 = new LeerService();
            //var maestros = ope1.LeerArchivo();
            //return View(maestros);
            return null;
        }
    }
}