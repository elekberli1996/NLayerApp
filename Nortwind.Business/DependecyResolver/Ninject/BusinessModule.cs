using Ninject.Modules;
using Nortwind.Business.Abstract;
using Nortwind.Business.Concrete;
using Nortwind.DataAccess.Abstract;
using Nortwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.DependecyResolver.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            //birisi senen bi sey isterse ona karsiligini ver
            Bind<IProductService>().To<ProductManager>().InSingletonScope();//performansi artirir metodla
            Bind<IProductDal>().To<EfProductDal>();

            Bind<ICatagoryService>().To<CatagoryManager>();
            Bind<ICatagoryDal>().To<EfCatagoryDal>();
        }
    }
}
