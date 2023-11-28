using Microsoft.AspNetCore.Mvc;
using ProjectPrn211.Models;
using System.Security.Cryptography;

namespace ProjectPrn211.Controllers
{
	public class ProductController : Controller
	{
		ElectroContext context = new ElectroContext();
		
		[HttpPost]
		public IActionResult Detail()
		{
			var account = HttpContext.Session.GetObject<Account>("userlogin");
			if (account == null)
			{

				return RedirectToAction("Login", "Login");
			}
			else
			{
				int pid = Int32.Parse(HttpContext.Request.Form["pid"]);
				int rating = Int32.Parse(HttpContext.Request.Form["rating"]);
				string commment = HttpContext.Request.Form["commment"];
				string img = HttpContext.Request.Form["image"];
				Feedback feedback = new Feedback()
				{
					IssueDate = DateTime.Now,
					UserId = account.UId,
					Pid = pid,
					Name = account.User,
					Img = img,
					Star = rating,
					Comment = commment,
				};

				context.Feedbacks.Add(feedback);
				context.SaveChanges();

				Product product = context.Products.FirstOrDefault(x => x.Id == pid);
				List<Feedback> feedbackList = context.Feedbacks.Where(f => f.Pid == pid).ToList();
				ViewBag.FeedbackList = feedbackList;
				ViewBag.Product = product;
				return View();
			}

		}
		public IActionResult Delete(int feedbackId, int pid)
		{
			var account = HttpContext.Session.GetObject<Account>("userlogin");

			if (account == null)
			{
				return RedirectToAction("Login", "Login");
			}
			var feedback = context.Feedbacks.FirstOrDefault(f => f.Fid == feedbackId);
			context.Feedbacks.Remove(feedback);
			context.SaveChanges();
			Product product = context.Products.FirstOrDefault(x => x.Id == pid);
			List<Feedback> feedbackList = context.Feedbacks.Where(f => f.Pid == pid).ToList();
			ViewBag.FeedbackList = feedbackList;
			ViewBag.Product = product;
			return RedirectToAction("Detail", product);
		}

	}
}
