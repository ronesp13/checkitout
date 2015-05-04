using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ProjectCS.Models;

namespace ProjectCS.Filters
{
    public class CurrentUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var userManager = filterContext.HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var id = filterContext.HttpContext.User.Identity.GetUserId();
            ApplicationUser currentUser = null;
//if (id == null) return;
            currentUser = userManager.FindById(id);
            filterContext.Controller.ViewBag.CurrentUser = currentUser;
        }
    }
}