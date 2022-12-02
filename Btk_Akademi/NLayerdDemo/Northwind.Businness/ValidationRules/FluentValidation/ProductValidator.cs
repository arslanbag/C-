using FluentValidation;
using Northwind.Entites.Abstracts;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product> 
    {

        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0); //0 yada sıfırdan büyük
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2); //categori 2 ise price minumum 10 olmalı

            RuleFor(p => p.ProductName).Must(StartWithA);// kendi kuralını yaz
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
            //StartWith String methodu başlangıç karakteri A ile başlıyorsa True döner
        }
    }
}
