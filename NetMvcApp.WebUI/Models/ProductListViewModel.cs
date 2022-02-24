using NetMvcApp.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMvcApp.WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product>Products { get; internal set; }
    }
}
