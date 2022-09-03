using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public  class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("yazar adını boş geçemessiniz");
            RuleFor(x => x.writerSurName).NotEmpty().WithMessage("soyadı adını boş geçemessiniz");
            RuleFor(x => x.writerTitle).NotEmpty().WithMessage("soyadı adını boş geçemessiniz");
            RuleFor(x => x.writerAbout).NotEmpty().WithMessage("hakkında kısmını boş geçemessiniz");
            RuleFor(x => x.writerAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi içermelidir");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.writerSurName).MaximumLength(20).WithMessage("lütfen en fazla 50 karakter girişi yapınız");

        } 

        }

    }
