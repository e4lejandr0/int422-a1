using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using INT422A1.Models;

namespace INT422A1.Controllers
{
    public class PhoneController : Controller
    {
        static private PhoneContext db = new PhoneContext();

        [Route("phones")]
        public IActionResult Index()
        {
            return View(db.Phones);
        }

        [HttpGet("/phones/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/phones/create")]
        public IActionResult New([Bind("PhoneName,Manufacturer,MSRP,DateReleased,ScreenSize")] Phone newPhone)
        {
            newPhone.Id = Guid.NewGuid();
            db.Add(newPhone);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("/phones/{id}/edit")]
        public IActionResult Edit(Guid Id)
        {

            var phoneData = from p in db.Set<Phone>()
                              where p.Id == Id
                              select p;
            return View(phoneData.Single());
        }

        [HttpPost("/phones/{id}/edit")]
        [HttpPatch("/phones/{id}/edit")]
        public IActionResult Update(Guid Id)
        {
            Phone toUpdate = db.Phones.Where(p => p.Id == Id).FirstOrDefault();
            Console.WriteLine("Phone id: {0}", toUpdate.Id);

            //Phone oldPhone = db.Phones.Where(p => p.Id == Id).FirstOrDefault();
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete("/phones/{id}")]
        public IActionResult Delete([Bind("Id")] Phone deletedPhone)
        {
            db.Phones.Remove(deletedPhone);
            db.SaveChanges(); 
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
