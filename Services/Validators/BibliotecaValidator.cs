using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class BibliotecaValidator : AbstractValidator<Biblioteca>
    {
        public BibliotecaValidator()
        {
            RuleFor(c => c.Usuario)
                .NotNull().WithMessage("Usuário obrigatório.")
                .NotEmpty().WithMessage("Usuário obrigatório.");
            RuleFor(c => c.ListaJogos)
                .NotEmpty().WithMessage("Por favor informe os jogos da biblioteca.")
                .NotNull().WithMessage("Por favor informe os jogos da biblioteca.");
        }
    }
}
