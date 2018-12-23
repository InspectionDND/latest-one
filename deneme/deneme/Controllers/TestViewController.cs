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
    public class TestViewController : Controller
    {

       



        // Get        
        public async Task<ActionResult> Index()
        {
            List<Worker> worker = null;
            using (DenemeDb db = new DenemeDb())
            {
                worker = await db.Workers.ToListAsync();

                if (worker == null)
                    return HttpNotFound();
                
            }

               


                    //TestModel testModel = new TestModel()
                    //{
                    //    Name = worker[0].Name,
                    //    Age = worker[0].Age,
                    //    Email = worker[0].Email,
                    //    FatherName = worker[0].FatherName,
                    //    Gender = worker[0].Gender,
                    //    PhoneNumber = worker[0].PhoneNumber,
                    //    RTcode = worker[0].RTcode,
                    //    StartTime = worker[0].StartTime,
                    //    Surname = worker[0].Surname,
                    //    TravelExpenses = worker[0].TravelExpenses,
                    //    VehicleNumber = worker[0].VehicleNumber,
                    //    Position = worker[0].Position,

                    //};
                    return View(/*testModel*/);
        }




        [HttpPost]
        public async Task<ActionResult> WorkerAdd(TestModel testModel)
        {
            if (testModel == null)
                return RedirectToAction("WorkerAdd","TestView");


            using (DenemeDb db = new DenemeDb())
            {
                Worker worker = (Worker)testModel;

                db.Workers.Add(worker);
                await db.SaveChangesAsync();
            }
           
            return RedirectToAction("Index","TestView");

        }

        



    }
}