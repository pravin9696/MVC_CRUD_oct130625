using MVC_CRUD_oct130625.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_oct130625.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllStudents() //select method
        {
            //step1  Create object of DBContext class and use it to interact with DB
            DB_Oct_StudentEntities dbo = new DB_Oct_StudentEntities();

            //step 2 //read all student record with the help of dbContext class methods
            List<tblStudent> studList = dbo.tblStudents.ToList();

            return View(studList);//<===
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
                       //Create method
        public ActionResult AddStudent(tblStudent std)
        {
            //step1  Create object of DBContext class and use it to interact with DB
            DB_Oct_StudentEntities dbo = new DB_Oct_StudentEntities();

            //step2 add object of tblstudent into dbo using library method

            dbo.tblStudents.Add(std);

            int n = dbo.SaveChanges();
            if (n > 0)
            {
                ViewBag.msg = "Record inserted Successfully";
            }
            else
            {
                ViewBag.msg = "Record not inserted!!!!";
            }
            return View();
        }
    }
}