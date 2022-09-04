﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public  class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
            {
            RuleFor(x => x.SkillName).NotEmpty().WithMessage("Yetenek Adını Boş Geçemessiniz");
            RuleFor(x => x.SkillValue).NotEmpty().WithMessage("Değer kısmını boş geçemessiniz");
            RuleFor(x => x.SkillValue).LessThanOrEqualTo(100).WithMessage("Yetenek Değeri En Fazla 100 Olabilir");
            RuleFor(x => x.SkillValue).GreaterThan(0).WithMessage("Yetenek Değeri En Az 0 Olabilir");
            RuleFor(x => x.SkillName).MaximumLength(50).WithMessage("Yetenek İsmi En Fazla 50 Karekterden Oluşabilir");
            RuleFor(x => x.SkillName).MinimumLength(1).WithMessage("Yetenek İsmi En Az 3 Karekterden Oluşabilir");
        }
    }
}
