using Microsoft.AspNet.Identity;
using Panele.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;

namespace Panele.Controllers
{
    public class AccountController : Controller
    {
		#region referencje do managerow z contextu owin
		private ApplicationSignInManager _signInManager;
		private ApplicationUserManager _userManager;

		public ApplicationSignInManager SignInManager
		{
			get
			{
				return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
			}
			private set
			{
				_signInManager = value;
			}
		}

		public ApplicationUserManager UserManager
		{
			get
			{
				return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
			}
			private set
			{
				_userManager = value;
			}
		}

		private IAuthenticationManager AuthenticationManager
		{
			get
			{
				return HttpContext.GetOwinContext().Authentication;
			}
		}
		#endregion


		[HttpGet]
		public ViewResult LogIn(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult LogIn(LogInViewModel model, string returnUrl)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			var result = SignInManager.PasswordSignIn(model.UserName, model.Password, false, false);
			switch (result)
			{
			case SignInStatus.Success:
				return RedirectToLocal(returnUrl);
			case SignInStatus.Failure:
			case SignInStatus.RequiresVerification:
			case SignInStatus.LockedOut:
			default:
				ModelState.AddModelError("", "Nieprawidłowa nazwa użytkownika lub hasło");
				return View(model);
			}
		}
		[HttpGet]
		public ViewResult Register()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Register(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				ApplicationUser user;
				ApplicationUserStore store = new ApplicationUserStore(new DAL.ShopContext());
				ApplicationUserManager userManager = new ApplicationUserManager(store);
				user = new ApplicationUser { UserName = model.UserName };
				var result = userManager.Create(user, model.Password);
				if (result.Succeeded)
					return RedirectToAction("Index", "Home", new { afterSuccessfulRegister = true });
				AddErrors(result);
			}
			return View(model);
		}
		private void AddErrors(IdentityResult result)
		{
			foreach (var error in result.Errors)
				ModelState.AddModelError("", error);
		}
		private ActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			return RedirectToAction("Index", "Home");
		}
	}
}