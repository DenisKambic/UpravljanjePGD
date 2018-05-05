using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpravljanjePGD.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Net;

namespace UpravljanjePGD.Controllers
{
	[Authorize]
	public class RoleController : Controller
	{
		ApplicationDbContext context;

		public RoleController()
		{
			context = new ApplicationDbContext();
		}

		public ActionResult Index()
		{

			if (User.Identity.IsAuthenticated)
			{


				if (!isAdminUser())
				{
					return RedirectToAction("Index", "Home");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}

			var Roles = context.Roles.ToList();
			return View(Roles);

		}
		public Boolean isAdminUser()
		{
			if (User.Identity.IsAuthenticated)
			{
				var user = User.Identity;
				var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
				var s = UserManager.GetRoles(user.GetUserId());
				if (s[0].ToString() == "Admin")
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			return false;
		}

		public ActionResult Create()
		{
			if (User.Identity.IsAuthenticated)
			{


				if (!isAdminUser())
				{
					return RedirectToAction("Index", "Home");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}

			var Role = new IdentityRole();
			return View(Role);
		}


		[HttpPost]
		public ActionResult Create(IdentityRole Role)
		{
			if (User.Identity.IsAuthenticated)
			{
				if (!isAdminUser())
				{
					return RedirectToAction("Index", "Home");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}

			context.Roles.Add(Role);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		// GET: Posts/Delete/5
		public ActionResult Delete(IdentityRole Role)
		{
			if (Role == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			if (context.Roles.Find(Role.Id) == null)
			{
				return HttpNotFound();
			}
			return View(context.Roles.Find(Role.Id));
		}

		// POST: Posts/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(IdentityRole Role)
		{
			context.Roles.Remove(context.Roles.Find(Role.Id));
			context.SaveChanges();
			return RedirectToAction("Index");
		}


	}
}