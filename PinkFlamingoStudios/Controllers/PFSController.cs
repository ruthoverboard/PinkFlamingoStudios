using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PinkFlamingoStudios.Models;

namespace PinkFlamingoStudios.Controllers
{
    public class PFSController : Controller
    {
        // GET: PFS
        PinkFlamingosEntities pf = new PinkFlamingosEntities(); 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult PreOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PreOrder(PreOrder order)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}