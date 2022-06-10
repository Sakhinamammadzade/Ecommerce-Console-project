using EcommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.Services
{
    public class ProductServices
    {
        List<Product> produtcs = new()
        {
            new Product
            {
                Id = 1,
                Name = "4 otaqli temirsiz ev",
                Description = " Müasier layihe esasında tikilib.Su, gaz işıq daimidir.",
                Otaqsayi = 4,
                Kupca = true,
                Updated = DateTime.Now,
                Created = DateTime.Now,
                Sahe = 110M,
                Price = 150000,
                Baxissayi = 200



            },
            new Product
            {
                Id = 2,
                Name = "3 otaqli temirsiz ev",
                Description = "heyet evi",
                Otaqsayi = 3,
                Kupca = true,
                Updated = DateTime.Now,
                Created = DateTime.Now,
                Sahe = 90M,
                Price = 110000,
                Baxissayi = 130


            },
            new Product
            {
                Id = 3,
                Name = " super temirli villa",
                Description = " Müasier layihe esasında tikilib.",
                Otaqsayi = 10,
                Kupca = true,
                Updated = DateTime.Now,
                Created = DateTime.Now,
                Sahe = 200M,
                Price = 350000,
                Baxissayi = 300



            },
            new Product
            {
                Id = 4,
                Name = " super temirli villa",
                Description = " Müasier layihe esasında tikilib.",
                Otaqsayi = 5,
                Kupca = true,
                Updated = DateTime.Now,
                Created = DateTime.Now,
                Sahe = 150M,
                Price = 250000,
                Baxissayi = 250



            },
            new Product
            {
                Id = 5,
                Name = " super temirli ev",
                Description = "  3 otaqlı tam təmirli və əşyalı mənzil",
                Otaqsayi = 3,
                Kupca = true,
                Updated = DateTime.Now,
                Created = DateTime.Now,
                Sahe = 90M,
                Price = 150000,
                Baxissayi = 50



            }
        };

        public List<Product> GetAll() //metodunu harda cagirsaq bize productu getircek
        {
            return produtcs;
        }


        public Product GetbyId(int id)
        {
            var product =produtcs.FirstOrDefault(x => x.Id == id);
            product.Baxissayi += 1;
            return product; 
        }




        public List<Product> GetFilter(string Desc)
        {
            return produtcs.Where(x=>x.Description==Desc).ToList();
        }




     
    }
}