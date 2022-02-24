using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetMvcApp.Nortwind.Business.Abstract;
using NetMvcApp.WebUI.Models;

namespace NetMvcApp.WebUI.Controllers
{
    public class ProductController:Controller
    {
       private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page=1,int category=0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page-1)*pageSize).Take(pageSize).ToList()
            };
            return View(model);
        }
    }
}
