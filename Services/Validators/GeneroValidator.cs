using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome do Gênero obrigatório.")
                .NotNull().WithMessage("Nome do Gênero obrigatório.");
        }
    }
}
