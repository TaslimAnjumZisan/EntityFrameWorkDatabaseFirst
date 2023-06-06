using EntityFrameWorkDatabaseFirst.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWorkDatabaseFirst.Controllers
{
    public class BlogController : Controller
    {
        BlogContext db = new BlogContext();
        // GET: Blog
        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }
    }
}