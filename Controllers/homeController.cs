using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class homeController : Controller
    {
        dtDataContext db = new dtDataContext();
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult indexmain()
        {
            return View(db.cardds.ToList()); 
        }
        public ActionResult admin()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult adduser(cardd d)
        {
            db.cardds.InsertOnSubmit(d);
            db.SubmitChanges();
            return RedirectToAction("indexmain");
        }
        
    }
}