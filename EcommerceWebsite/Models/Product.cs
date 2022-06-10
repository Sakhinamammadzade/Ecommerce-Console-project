using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Otaqsayi { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Sahe { get; set; }
        public bool Kupca { get; set; }
        public string Description { get; set; }
        public int Baxissayi { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }



    }
}
