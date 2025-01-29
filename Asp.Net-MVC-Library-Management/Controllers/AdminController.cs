using AspNetMVCLibraryManagement.Model;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;


namespace OpenCMS.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllLibraryUsers()
        {
            LibraryDBContext dbContext = new LibraryDBContext();

            var allUsers = dbContext.Users.ToList();

            return View(allUsers);
        }


        public ActionResult Edit(int Id)
        {   
            if (Id != 0)
            {
                using (var dbContext = new LibraryDBContext())
                {
                    User usr = dbContext.Users.Where(x => x.Id == Id).ToList().FirstOrDefault();
                    return View(usr);
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(User usr)
        {
            using (var dbContext = new LibraryDBContext())
            {
                dbContext.Users.AddOrUpdate(usr);
                dbContext.SaveChanges();
                return View();
            }           
        }
    }
}