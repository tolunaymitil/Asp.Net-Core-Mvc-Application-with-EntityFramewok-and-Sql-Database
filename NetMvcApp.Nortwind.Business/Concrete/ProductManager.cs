using NetMvcApp.DataAccess.Abstract;
using NetMvcApp.Northwind.Entities.Concrete;
using NetMvcApp.Nortwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMvcApp.Nortwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            var data= _productDal.GetList();

            return data;
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p=>p.CategoryId==categoryId ||categoryId==0);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
