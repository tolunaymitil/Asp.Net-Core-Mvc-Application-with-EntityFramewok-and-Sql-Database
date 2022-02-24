using NetMvcApp.Core.DataAccess.EntityFramework;
using NetMvcApp.DataAccess.Abstract;
using NetMvcApp.Northwind.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMvcApp.DataAccess.Concrete.EntityFramework
{
   public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
