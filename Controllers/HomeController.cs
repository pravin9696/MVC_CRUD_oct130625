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
            DB_Oct_StudentEntities dbo = new DB_Oct_StudentEntities();
            List<tblStudent> studList = dbo.tblStudents.ToList();
            return View(studList);
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
        [HttpGet]
        public ActionResult SearchStudent()
        {
            if (TempData["msg"] != null)
            {
                ViewBag.msg = TempData["msg"];
            }

            return View();
        }
        [HttpGet]
        public ActionResult Edit(int txtRoll)
        {
            DB_Oct_StudentEntities dbo = new DB_Oct_StudentEntities();
            tblStudent std = dbo.tblStudents.FirstOrDefault(x => x.RollNo == txtRoll);
            if (std!=null)
            {
                return View(std);
            }
            else
            {
                TempData["msg"] = "record not found!!!!!";
                return RedirectToAction("SearchStudent");
            }
                
        }
        [HttpPost]
        public ActionResult Edit(tblStudent std)
        {
            DB_Oct_StudentEntities dbo = new DB_Oct_StudentEntities();

            tblStudent tempStudent = dbo.tblStudents.FirstOrDefault(x => x.RollNo == std.RollNo);
            if (tempStudent!=null)
            {
                tempStudent.RollNo = std.RollNo;
                tempStudent.Name = std.Name;
                tempStudent.DOB = std.DOB;
                tempStudent.TotalMarks = std.TotalMarks;
                tempStudent.FeesPaid = std.FeesPaid;

                int n = dbo.SaveChanges();
                if (n>0)
                {
                    TempData["msg"] = "Record updated Successfully....";
                    //return RedirectToAction("SearchStudent");
                    return RedirectToAction("Index");
                }
                else
                {
                   
                }
            }
            return View();
        }
        }
}