using NetMvcApp.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMvcApp.Nortwind.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
