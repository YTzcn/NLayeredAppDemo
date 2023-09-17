using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Northwind.Bussines.Abstract;
using Northwind.Bussines.Concrete;
using Northwind.Bussines.Concrete.EntityFramework;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;

namespace Northwind.Bussines.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        
        }
    }
}
