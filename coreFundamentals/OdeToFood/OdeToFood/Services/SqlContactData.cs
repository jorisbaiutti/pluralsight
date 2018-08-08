
using System.Linq;
using System.Collections.Generic;
using OdeToFood.Data;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class SqlContactData : IFoodContact
    {
        private OdeToFoodDbContext _context;


        public SqlContactData(OdeToFoodDbContext context)
        {
            _context = context;
        }

        public FoodContact Add(FoodContact foodContact)
        {
            _context.Add(foodContact);
            _context.SaveChanges();
            return foodContact;
        }

        public FoodContact get(int id)
        {
           return _context.Contacts.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<FoodContact> getAll()
        {
           return _context.Contacts.OrderBy(c => c.Name);
        }
    }
}
