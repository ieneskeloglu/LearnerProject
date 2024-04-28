using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LearnerProject.Controllers
{
    public class TeacherLoginController : Controller
    {
        Context context=new Context();
        // GET: TeacherLogin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Teacher teacher)
        {
            var values=context.Teachers.FirstOrDefault(x=>x.Username==teacher.Username && x.Password==teacher.Password);
            if (values==null)
            {
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(values.Username,false);
                Session["teacherName"]=values.NameSurname;
                return RedirectToAction("Index","TeacherCourse");
            }
        }
    }
}