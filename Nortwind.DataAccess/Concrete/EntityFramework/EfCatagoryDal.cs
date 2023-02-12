using Nortwind.DataAccess.Abstract;
using NortwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfCatagoryDal:EfEntityRepositoryBase<Category,NortwindContext>,ICatagoryDal
    {
    }
}
