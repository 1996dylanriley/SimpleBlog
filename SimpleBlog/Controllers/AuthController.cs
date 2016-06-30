using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin { });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid) //This tells mvc what to do if the required fields in the model(auth.cs) are invalid.
            return View(form); // the form parameter here means retrun the form as it was submitted(the post request).

            if (form.UserName != "dylan riley")
            {
                ModelState.AddModelError("UserName", "Your username proves to me that you are not a boss!");
                return View(form);
            }

            return Content("The form is valid");
        }
    }
}