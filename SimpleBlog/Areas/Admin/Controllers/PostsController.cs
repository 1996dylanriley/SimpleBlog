using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")] // This tell mvc that you cannot access this page if you are not logged in or your role isn't allow
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        public ActionResult Index()
        {
            return View();
        }
    }
}