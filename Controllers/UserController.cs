using MVC_CRUD_oct130625.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_oct130625.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            List<int> AgeList = Enumerable.Range(18,83).ToList();
            ViewBag.AgeList = AgeList;
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(tblUser tuser)
        {
            DB_Oct_StudentEntities dbo = new DB_Oct_StudentEntities();

            dbo.tblUsers.Add(tuser);

            int n = dbo.SaveChanges();
            if (n > 0)
            {
                ViewBag.msg = "Record inserted Successfully..";
            }
            else
            {
                ViewBag.msg = "Error!!!...";
            }
            List<int> AgeList = Enumerable.Range(18, 83).ToList();
            ViewBag.AgeList = AgeList;
            return View();
        }
    }
}