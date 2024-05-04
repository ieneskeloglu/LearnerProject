using LearnerProject.Models;
using LearnerProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class DefaultController : Controller
    {
        Context context=new Context();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DefaultCoursePartial()
        {
          
            var values=context.Courses.Include(x=>x.Reviews).OrderByDescending(x=>x.CourseId).Take(3).ToList();
            return PartialView(values);
        }

        public ActionResult CourseDetail(int id)
        {
            var values=context.Courses.Find(id);
            var reviewList=context.Reviews.Where(x=>x.CourseId==id).ToList();
            ViewBag.value = reviewList;
            return View(values);
        }
    }
}