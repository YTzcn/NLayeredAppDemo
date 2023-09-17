using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>() 
            {
               new Product()
               {
                   CategoryId = 1,
                   ProductId = 1,
                   ProductName = "Test",
                   QuantityPerUnit ="1 box a Koli",
                   UnitPrice =50,
                   UnitsInStock=500
               }
            };
            return list;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
