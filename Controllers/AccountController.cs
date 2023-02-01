using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace facebookClone.Controllers
{
    public class AccountController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //configure user is not logged in
            string username = User.Identity.Name;
            if (!string.IsNullOrEmpty(username)) return Redirect("~/" + username);
            //
            return View();
        }
    }
}