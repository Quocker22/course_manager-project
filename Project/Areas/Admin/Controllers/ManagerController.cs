using Project.Areas.Admin.Models.ADO.NET;
using Project.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Areas.Admin.Controllers
{
    public class ManagerController : Controller
    {
        //
        // GET: /Admin/Manager/
        public ActionResult Course()
        {
            //Main_COURSE obj = new Main_COURSE();
            //List < Course > listcour = obj.getdata();
            //return View(listcour);
            CourseList listCour = new CourseList();
            List<Course> obj = listCour.getCourse(string.Empty).OrderBy(x => x.MA_COURSE).ToList();
            return View(obj);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course cour)
        {
            if(ModelState.IsValid)
            {
                CourseList listCour = new CourseList();
                listCour.addCourseNew(cour);
                return RedirectToAction("Course");
            }
            return View();
        }
        
	}
}