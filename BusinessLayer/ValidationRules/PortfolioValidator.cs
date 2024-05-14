using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş olamaz.");
            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Image URL boş olamaz.");
            RuleFor(x => x.ImageURL2).NotEmpty().WithMessage("Image2 URL boş olamaz.");
            RuleFor(x => x.ProjectURL).NotEmpty().WithMessage("Proje URL boş olamaz.");
            RuleFor(x => x.ProjectURL).MinimumLength(2).WithMessage("Proje adı en az 2 karakter olmalı.");
        }
    }
}
