using Microsoft.AspNetCore.Mvc;
using ProjectPrn211.Models;

namespace StudenPtFeedback.Controllers
{
    public class QuestionController : Controller
    {
        ElectroContext context = new ElectroContext();
        public IActionResult Index()
        {
            var question = context.Questions.FirstOrDefault(fb => fb.QuestionId == 1);
            ViewBag.Question = question;
            return View();
        }

        public IActionResult Check1()
        {
            string key = HttpContext.Request.Form["q1"];
            var question = context.Questions.FirstOrDefault(fb => fb.QuestionId == 1);
            if (key == question.Answer)
            {
                return RedirectToAction("Index2");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Index2()
        {
            var question = context.Questions.FirstOrDefault(fb => fb.QuestionId == 2);
            ViewBag.Question = question;
            return View();
        }

        public IActionResult Check2()
        {
            string key = HttpContext.Request.Form["q2"];
            var question = context.Questions.FirstOrDefault(fb => fb.QuestionId == 2);
            if (key == question.Answer)
            {

                return View("Index3");
            }
            else
            {
                return RedirectToAction("Index2");
            }
        }

    }
}
