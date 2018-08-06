using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Models;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryContactData : IContact
    {
        List<FoodContact> _contacts;

        public InMemoryContactData()
        {
            _contacts = new List<FoodContact>
            {
                new Models.FoodContact { Name = "Joris Baiutti", Street = "Melchtalstrasse 18", City =  "Bern", Phone =  "0799999999"},
                new Models.FoodContact { Name = "Jacqueline Marmet", Street = "Melchtalstrasse 18", City =  "Bern", Phone =  "0799234439"},
                new Models.FoodContact { Name = "Test user", Street = "Bernstrasse 30", City =  "Zürich", Phone =  "0799123123999"}
            };
        }

        public IEnumerable<FoodContact> getAll()
        {
            return _contacts.OrderBy(c => c.Name);
        }
    }
}
