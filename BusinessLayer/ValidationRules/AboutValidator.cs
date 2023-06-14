using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz").MinimumLength(50).WithMessage("Lütfen en az 50 karakter giriniz.").MaximumLength(1500).WithMessage("Lütfen Daha az karakter giriniz.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Resim Seçiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz");
        }
    }
}
