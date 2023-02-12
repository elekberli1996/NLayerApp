using Nortwind.DataAccess.Abstract;
using NortwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.EntityFramework
{
    public  class EfProductDal:EfEntityRepositoryBase<Product,NortwindContext>
    {
        // yanliz database islemleri yapilir
    }
}
