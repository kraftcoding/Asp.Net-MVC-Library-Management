using AspNetMVCLibraryManagement.Model;
using System.Web.Mvc;
using System.Web.Security;

namespace Asp.Net_MVC_Library_Management.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            if (!string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Password))
            {
                if (model.Email.ToString() == "admin" && model.Password.ToLower() == "admin")
                {
                    //FormsAuthentication.SetAuthCookie(model.Email, true);
                    //Response.Redirect("/Admin/Index");
                }
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            FormsAuthentication.RedirectToLoginPage();

            return RedirectToAction("Login", "Account");
        }
    }
}