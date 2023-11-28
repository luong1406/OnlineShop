using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectPrn211.Models;

namespace ProjectPrn211.Controllers
{

public static class SessionExtensions
	{
		public static void SetObject(this ISession session, string key, object value)
		{
			session.SetString(key, JsonConvert.SerializeObject(value));
		}

		public static T GetObject<T>(this ISession session, string key)
		{
			var value = session.GetString(key);
			return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
		}
	}
	public class LoginController : Controller
	{
		ElectroContext context = new ElectroContext();
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(int id)
		{
			string user = HttpContext.Request.Form["user"];
			string pass = HttpContext.Request.Form["password"];
			var ctd = context.Accounts.SingleOrDefault(x => x.User.Equals(user) && x.Pass.Equals(pass));
		if (ctd != null)
			{
             HttpContext.Session.SetObject("userlogin", ctd);		
			return RedirectToAction("Index","Product");
				
			}
			else
			{
				TempData["eror"] = "wrong username or password";
				return View();
			}
		}
	  public IActionResult Logout()
		{  
		    
			return RedirectToAction("Login", "Login");
		}
	
	}
}
