using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class ConquistaValidator : AbstractValidator<Conquista>
    {
        public ConquistaValidator()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Descrição da Conquista obrigatória.")
                .NotNull().WithMessage("Descrição da Conquista obrigatória.");
            RuleFor(c => c.Jogo)
                .NotEmpty().WithMessage("Jogo obrigatório.")
                .NotNull().WithMessage("Jogo obrigatório.");
        }
    }
}
