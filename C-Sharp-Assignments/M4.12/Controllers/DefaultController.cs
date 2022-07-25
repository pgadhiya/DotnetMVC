using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M4._12.Controllers
{
    //12. Create one example to store data in session and show on other view.
    //18. Pass one values from one view to another view using query string.


    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string uname = fc["txtuname"];
            string pass = fc["txtpass"];

            if (uname == "prakash" && pass == "123")
            {
                HttpCookie couname = new HttpCookie("uname");
                couname.Expires = DateTime.Now.AddDays(2);  // for persistant cookies
                couname.Value = uname;
                Response.Cookies.Add(couname);

                HttpCookie copass = new HttpCookie("pass");
                copass.Expires = DateTime.Now.AddDays(2);
                copass.Value = pass;
                Response.Cookies.Add(copass);
            }
            return View();
        }
        // Store data in query string/url and show in another view
        public ActionResult QueryString()
        {
            return View();
        }
        public ActionResult GetQ(string fname, string mobile)
        {
            ViewBag.fname = fname;
            ViewBag.mobile = mobile;
            return View();
        }

        // Save data in Session 

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string uname = fc["txtuname"];
            string pass = fc["txtpass"];

            if (uname == "prakash" && pass == "123")
            {
                //cookie
                Session["uname"] = uname;
                Session["pass"] = pass;
                Session.Timeout = 30;
                return RedirectToAction("HomePage");
            }
            else
            {
                ViewBag.loginerror = "Invalid Username or Password.!";
            }
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
        // Display data from temp data to another view
        public ActionResult svar()
        {
            ViewData["info"] = "Writing info to View Data";
            ViewBag.msg = "Writing message to View Bag";
            TempData["data"] = "Displaying data from Temp Data";
            return View();
        }

        public ActionResult Second()
        {
            return View();
        }
    }
}