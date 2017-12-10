using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Panele.DAL;
using Panele.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Panele
{
	public class ApplicationUserStore : UserStore<ApplicationUser> //application w nazwach klas jest z tutoriala, potem mozna zmienic na Shop czy cos
	{
		public ApplicationUserStore(ShopContext context) :base(context)
		{
		}
	}
	public class ApplicationUserManager : UserManager<ApplicationUser>
	{
		public ApplicationUserManager(IUserStore<ApplicationUser> store) :base(store)
		{
		}
		public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
		{
			var store = new UserStore<ApplicationUser>(context.Get<ShopContext>());
			var manager = new ApplicationUserManager(store);
			return manager;
		}
	}
	public class ApplicationSignInManager :SignInManager<ApplicationUser, string>
	{
		public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
			:base(userManager, authenticationManager)
		{
		}
		public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
		{
			return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
		}
	}
}