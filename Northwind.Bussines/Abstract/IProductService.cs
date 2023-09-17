using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.Bussines.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductByCategory(int CategoryId);
        List<Product> GetProductsByName(string key);
        void Update(Product product);
    }
}
