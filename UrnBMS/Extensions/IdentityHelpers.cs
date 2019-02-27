using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Web.Mvc;

namespace UrnBMS.Extensions
{
	public static class IdentityHelpers
	{
		public static MvcHtmlString GetUserFullName(this HtmlHelper html, string id)
		{
			ApplicationUserManager userManager
				= HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();

			return new MvcHtmlString(
				userManager.FindByIdAsync(id).Result.FirstName 
				+ userManager.FindByIdAsync(id).Result.LastName);
		}
	}
}
