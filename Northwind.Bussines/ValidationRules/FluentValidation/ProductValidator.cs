using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Bussines.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //fluentvalidaton dökümantasyonuna bak 
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Birim Fiyatı Boş Olmamalı");
            RuleFor(p => p.QuantityPerUnit).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Birim Fiyatı 0'dan büyük olmalı");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0).WithMessage("Stok Adedi Sıfıra Eşit Veya Büyük Olmalı");
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(P => P.CategoryId == 2);

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün Adı A İle Başlamalıdır");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith('A');
        }
    }
}
