using deneme.Models;
using deneme.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace deneme.Controllers
{
    public class MarketController : Controller
    {
        // GET: Market
        public async Task<ActionResult> Index()
        {

          
                List<Market> markets = null;
                using (DenemeDb db = new DenemeDb())
                {
                    markets = await db.Markets.ToListAsync();

                    if (markets == null)
                        return HttpNotFound();

                }




              
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> MarketAdd(MarketAdded marketAdded)
        {
            if (marketAdded == null)
                return RedirectToAction("MarketAdd", "Market");


            using (DenemeDb db = new DenemeDb())
            {
                Market market = (Market)marketAdded;

                db.Markets.Add(market);
                await db.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Market");

        }
    }
}