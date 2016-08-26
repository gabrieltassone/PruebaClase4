using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_MVC_Music_Store.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prueba
        public ActionResult Index2()
        {
            return View("View");
        }

        // GET: Prueba
        public ActionResult AccionConOtraVista()
        {
            return RedirectToAction("Index", "Home"); //pasa por la accion para recuperar datos y devolver la vista
            //return View("../Home/Index"); busca el archivo fisico y lo renderiza directamente
        }
    }
}