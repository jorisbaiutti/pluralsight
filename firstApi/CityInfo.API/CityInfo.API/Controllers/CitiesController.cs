﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public JsonResult getCities()
        {
            return new JsonResult(CitiesDataStore.Current);
        }

        [HttpGet("{id}")]
        public IActionResult getCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(item => item.Id == id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
