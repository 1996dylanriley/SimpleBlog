using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")] //this here is known as a filter
    [SelectedTab("users")]
    public class UsersController : Controller
    {

        // GET: Admin/Users
        public ActionResult Index()
        {
            return View();
        }
    }
}