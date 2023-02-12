using Nortwind.Business.Abstract;
using Nortwind.DataAccess.Abstract;
using NortwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Concrete
{
    public class CatagoryManager : ICatagoryService
    {
        private ICatagoryDal _catagoryDal;
        public CatagoryManager(ICatagoryDal catagoryDal)
        {
            _catagoryDal = catagoryDal;

        }
        public List<Category> getAll()
        {
            return _catagoryDal.GetAll();
        }
    }
}
