using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class JogoGeneroValidator : AbstractValidator<JogoGenero>
    {
        public JogoGeneroValidator()
        {
            RuleFor(c => c.Jogo)
                .NotNull().WithMessage("Jogo obrigatório.")
                .NotEmpty().WithMessage("Jogo obrigatório.");
            RuleFor(c => c.Genero)
                .NotNull().WithMessage("Gênero obrigatório.")
                .NotEmpty().WithMessage("Gênero obrigatório.");
        }

    }
}
