using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
   
    public class ContactController : Controller
    {
        private IContact _contactData;

        public ContactController(IContact contactData)
        {
            _contactData = contactData;
        }

       
        public IActionResult Contacts()
        {
            var model = new ContactViewModel();
            model.Contacts = _contactData.getAll();
            return View(model);
        }
    }
}
