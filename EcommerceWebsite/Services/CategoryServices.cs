using EcommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.Services
{
   public class CategoryServices
    {
        List<Category> categories = new()
        {new Category { Id = 1, Name ="Telefon"}

        };

        public List<Category> GetAllCategories()
        {
            return categories;
        }
    }
}
