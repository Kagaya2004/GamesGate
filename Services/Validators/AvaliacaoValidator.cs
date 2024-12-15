using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class AvaliacaoValidator : AbstractValidator<Avaliacao>
    {
        public AvaliacaoValidator()
        {
            RuleFor(c => c.Comentario)
                .NotEmpty().WithMessage("Comentário obrigatório.")
                .NotNull().WithMessage("Comentário obrigatório");
            RuleFor(c => c.Classificacao)
                .NotEmpty().WithMessage("Classificação obrigatória.")
                .NotNull().WithMessage("Classificação obrigatória.");
            RuleFor(c => c.Jogo)
                .NotNull().WithMessage("Jogo obrigatório.")
                .NotEmpty().WithMessage("Jogo obrigatório.");
            RuleFor(c => c.Usuario)
                .NotNull().WithMessage("Usuário obrigatório.")
                .NotEmpty().WithMessage("Usuário obrigatório.");
        }
    }
}
