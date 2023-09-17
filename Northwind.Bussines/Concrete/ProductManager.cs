using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind.Bussines.Abstract;
using Northwind.Bussines.Utilities;
using Northwind.Bussines.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.Bussines.Concrete.EntityFramework
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(),product);
            _productDal.AddProduct(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.DeleteProduct(product);
            }
            catch
            {
                throw new Exception("Güncelleme Gerçekleşemedi");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductByCategory(int CategoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == CategoryId);
        }

        public List<Product> GetProductsByName(string key)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(key.ToLower()));

        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.UpdateProduct(product);
        }
    }
}
