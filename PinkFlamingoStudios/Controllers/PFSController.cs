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
        BusinessLogic bl = new BusinessLogic();
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

        [HttpPost]
        public ActionResult Contact(sendEmail email)
        {
            if (ModelState.IsValid)
            {
                bl.sendMail(email.Email, email.msg);
            }
           
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
                bl.addOrder(order.firstName, order.secondName, order.firstLastName, order.secondLastName, order.email);
            }
            return View();
        }
    }
}