using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using UpravljanjePGD.Models;

namespace UpravljanjePGD.Controllers
{
	public class HomeController : Controller
	{
		private ApplicationDbContext db = new ApplicationDbContext();
		public ActionResult Index()
		{
			var posts = db.Posts.OrderByDescending(p => p.Date).Take(5);

			return View(posts.ToList());
		}

		public ActionResult Zgodovina()
		{
			ViewBag.Message = "Kratek opis naše organizacije!";

			return View();
		}

		public ActionResult Kontakt()
		{
			ViewBag.Message = "Naši kontaktni podatki!";

			return View();
		}


		public ActionResult Posts(){

			return View();
		}
	}
}