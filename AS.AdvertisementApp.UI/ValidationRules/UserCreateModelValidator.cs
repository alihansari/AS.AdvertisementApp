using AS.AdvertisementApp.UI.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş olamaz");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Parola minumun 3 karakter olmalıdır");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Parolar eşleşmiyor");
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Ad boş olamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı boş olamaz");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon boş olamaz")
            .MinimumLength(10).WithMessage("Telefon Numarası 10 karakterden az olamaz")
            .MaximumLength(20).WithMessage("Telefon Numarası 20 karakterden fazla olamaz");         
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı adı minumun 3 karakter olmalıdır");
            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçimi zorunludur");

        }
    }
}
