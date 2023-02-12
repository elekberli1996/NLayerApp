
using FluentValidation;
using NortwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Nortwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        //slippet kod kisa yollari
        //fluent validation documentasyon
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("urun ismi bos olamaz");//bos olamaz
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.CategoryID).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);//0 dan buyuk olmali
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryID == 2);
            //catagoriid 2 olanda 10an asaqi olamaz

            //kendimizden kural yaza biliriz

            RuleFor(p => p.ProductName).Must(Startwith).WithMessage("urun ismi A ile baslamali");// a ile baslamali




        }

        private bool Startwith(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
