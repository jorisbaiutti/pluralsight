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
        private IFoodContact _contactData;

        public ContactController(IFoodContact contactData)
        {
            _contactData = contactData;
        }

       
        public IActionResult Contacts()
        {
            var model = new ContactViewModel();
            model.Contacts = _contactData.getAll();
            return View(model);
        }

        public IActionResult Details(int Id)
        {
            var model = _contactData.get(Id);
            if(model == null)
            {
                return RedirectToAction(nameof(Contacts));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(ContactEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newContact = new FoodContact();
                newContact.Name = model.Name;
                newContact.Street = model.Street;
                newContact.Phone = model.Phone;
                newContact.City = model.City;
                newContact = _contactData.Add(newContact);
                return RedirectToAction(nameof(Details), new { id = newContact.Id });
            }
            else
            {
                return View();
            }
            
        }

    }
}
