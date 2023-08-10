using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Conceate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(appUser=>appUser.Name).NotEmpty().WithMessage("Ad alanı boş geilemez");
            RuleFor(appUser => appUser.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(appUser => appUser.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(appUser => appUser.Username).NotEmpty().WithMessage("Kulalnıcı adı alanı boş geçilemez");
            RuleFor(appUser => appUser.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(appUser => appUser.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(appUser => appUser.Password).Equal(appUser2 => appUser2.ConfirmPassword).WithMessage("Şifre ve şifre tekrar alanları aynı değil");
            RuleFor(appUser => appUser.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");
        }
    }
}
