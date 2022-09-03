using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
     public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.RecelverMail).NotEmpty().WithMessage("Mail adresini boş geçemssiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("konu adresini boş geçemssiniz");
            RuleFor(x => x.MesajContact).NotEmpty().WithMessage("Mail adresini boş geçemssiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız");
        }

}
}
