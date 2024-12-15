using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class JogoValidator : AbstractValidator<Jogo>
    {
        public JogoValidator()
        {
            RuleFor(c => c.Nome)
                .NotNull().WithMessage("Nome do Jogo obrigatório.")
                .NotEmpty().WithMessage("Nome do Jogo obrigatório.");

        }
    }
}
