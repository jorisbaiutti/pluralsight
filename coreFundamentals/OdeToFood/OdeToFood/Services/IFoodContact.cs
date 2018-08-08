
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IFoodContact
    {
        IEnumerable<FoodContact> getAll();
        FoodContact get(int id);
        FoodContact Add(FoodContact foodContact);
    }
}
