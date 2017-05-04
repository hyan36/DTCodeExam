using DT.CodeExam.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DT.CodeExam.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ExamModel exam)
        {
            var client = new NumberServices.NumberServicesClient();
            var converted = client.Spell(new NumberServices.Request()
            {
                Name = exam.Name,
                Number = exam.Number
            });
            var response = new ExamModel()
            {
                Name = converted.Name,
                Number = exam.Number,
                NumberString = converted.Number
            };
            return View(response);
        }
        public ActionResult About()
        {
            ViewBag.Message = "About the solution.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Haihao's contact.";
            return View();
        }
    }
}