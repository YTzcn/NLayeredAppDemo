using System.Linq.Expressions;
using Northwind.Entities.Abstract;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new() //IEntity Eklenmiş T türünde newlenebilir bi sınıf olmalı
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Filte gelirse filteye göre gelmezse hepsi gelecek
        T GetById(Expression<Func<T, bool>> filter);//Filtre zorunlı
        void DeleteProduct(T entity);
        void AddProduct(T entity);
        void UpdateProduct(T entity);
    }
}
