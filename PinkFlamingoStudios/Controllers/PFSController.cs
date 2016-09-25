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
            BusinessLogic.name = false;
            BusinessLogic.creditCard = false;
            BusinessLogic.address = false;
            return View("PreOrder");
        }

        [HttpPost]
        public ActionResult PreOrder(PreOrder order, creditCardInfo creditCard)
        {
            if(order.firstName == null && creditCard.creditCardNumber != null)  
            {
                if(creditCard != null)
                {
                    creditCard.idUser = 1;
                    pf.creditCardInfoes.Add(creditCard);
                    pf.SaveChanges();
                    BusinessLogic.name = true;

                    return View("PreOrder");
                }
                return View();
            }
            else 
            {

                    pf.PreOrders.Add(order);
                    pf.SaveChanges();
                    BusinessLogic.name = true;
                    BusinessLogic.creditCard = true;
                
                return View("CreditCard2");
            }
          
           
        }

        [HttpPost]
        public ActionResult CreditCard(creditCardInfo creditCard)
        {

            if (ModelState.IsValid)
            {
                pf.creditCardInfoes.Add(creditCard);
                pf.SaveChanges();
                BusinessLogic.name = true;
            }
            return View();
        }
    }
}