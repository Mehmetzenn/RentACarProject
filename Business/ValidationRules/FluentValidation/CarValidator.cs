using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("2 den Uzun olmalı!!");
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(1300).WithMessage("Günlük ücret 1300 den büyük olmalı");
            //RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Araba A harfi ile başlamalı!!");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); 
        }
    }
}
