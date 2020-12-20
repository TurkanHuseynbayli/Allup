using Allup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup1.ViewModels
{
    public class HomeVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
