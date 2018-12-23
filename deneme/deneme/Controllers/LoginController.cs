using deneme.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace deneme.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> UserCheck(string username, string pass)
        {
            List<Worker> workers = null;
            using (DenemeDb denemeDb = new DenemeDb())
            {
                workers = await denemeDb.Workers.ToListAsync();

                if (workers == null)
                    return HttpNotFound();
                else
                {
                    foreach (var item in workers)
                    {
                        if (username == item.Name && pass == item.RTcode)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
            }

            return RedirectToAction("Index", "Login");

        }
    }
}