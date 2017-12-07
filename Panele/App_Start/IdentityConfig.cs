using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
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
	public class IdentityConfig
	{
		public void Configuration(IAppBuilder app)
		{
			app.CreatePerOwinContext(() => new ShopContext());

			app.UseCookieAuthentication(new CookieAuthenticationOptions
			{
				AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
				LoginPath = new PathString("/Home/Login"),
			});
		}
	}
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

	}
}