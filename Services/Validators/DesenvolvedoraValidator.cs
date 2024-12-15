using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class DesenvolvedoraValidator : AbstractValidator<Desenvolvedora>
    {
        public DesenvolvedoraValidator()
        {
            RuleFor(c => c.Nome)
                .NotNull().WithMessage("Nome da Desenvolvedora obrigatório.")
                .NotEmpty().WithMessage("Nome da Desenvolvedora obrigatório.");
            RuleFor(c => c.Pais)
                .NotNull().WithMessage("País obrigatório.")
                .NotEmpty().WithMessage("País obrigatório.");
            RuleFor(c => c.Site)
                .NotNull().WithMessage("Site obrigatório.")
                .NotEmpty().WithMessage("Site obrigatório.");
            RuleFor(c => c.Email)
                .NotNull().WithMessage("Email obrigatório.")
                .NotEmpty().WithMessage("Email obrigatório.")
                .EmailAddress().WithMessage("Email inválido.");
            RuleFor(c => c.Descricao)
                .NotNull().WithMessage("Descrição obrigatório.")
                .NotEmpty().WithMessage("Descrição obrigatório.");
        }
    }
}
