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
            return View();
        }

        [HttpDelete("/phones/{id}")]
        public IActionResult Delete(Guid id)
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
