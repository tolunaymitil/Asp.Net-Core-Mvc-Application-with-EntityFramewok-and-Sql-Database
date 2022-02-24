using NetMvcApp.Core.DataAccess;
using NetMvcApp.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMvcApp.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
