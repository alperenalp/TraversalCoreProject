using EntityLayer;
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
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterliik açıklama bilgisi giriniz!");
            RuleFor(x => x.Description).MinimumLength(1500).WithMessage("Lütfen açıklamayı biraz kısaltın!!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz!");
        }
    }
}
