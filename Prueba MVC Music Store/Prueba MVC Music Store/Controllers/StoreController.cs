using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_MVC_Music_Store.Controllers
{
    public class StoreController : Controller
    {
        
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index() 2";
        }
        //
        // GET: /Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;
        }
        //
        // GET: /Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}