using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{//98
    public class AddGuestValidator:AbstractValidator<AddGuestDto>
    {
        public AddGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("en az 3 karekter giriniz");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("en az 2 karekter giriniz");
            RuleFor(x => x.City).MinimumLength(4).WithMessage("en az 4 karekter giriniz");
            RuleFor(x => x.City).MaximumLength(15).WithMessage("en az 15 karekter giriniz");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("en az 30 karekter giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("en az 30 karekter giriniz");
        }
    }
}
