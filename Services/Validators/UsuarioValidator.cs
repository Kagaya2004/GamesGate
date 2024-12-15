using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome do usuário obrigatório.")
                .NotNull().WithMessage("Nome do usuário obrigatório.");
            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("Login do usuário obrigatório.")
                .NotNull().WithMessage("Login do usuário obrigatório.");
            RuleFor(c => c.Email)
                .NotNull().WithMessage("Email obrigatório.")
                .NotEmpty().WithMessage("Email obrigatório.")
                .EmailAddress().WithMessage("Email inválido.");
            RuleFor(c => c.Senha)
                .NotNull().WithMessage("Senha obrigatória.")
                .NotEmpty().WithMessage("Senha obrigatória.")
                .MinimumLength(8).WithMessage("A senha precisa possuir, no mínimo, 8 caracteres.")
                .Matches(@"[A-Z]+").WithMessage("A senha precisa possuir, pelo menos, um caractere maíusculo.")
                .Matches(@"[a-z]+").WithMessage("A senha precisa possuir, pelo menos, um caractere minúsculo.")
                .Matches(@"[0-9]+").WithMessage("A senha precisa possuir, pelo menos, um algarismo.")
                .Matches(@"[\!\#\*\@\$\%\&]+").WithMessage("A senha precisa possuir, pelo menos, um desses caracteres especiais.");
            RuleFor(c => c.Status)
                .NotNull().WithMessage("Status obrigatório.")
                .NotEmpty().WithMessage("Status obrigatório.");
            RuleFor(c => c.DataNascimento)
                .NotNull().WithMessage("Data de Nascimento obrigatório.")
                .NotEmpty().WithMessage("Data de Nascimento obrigatório.");
            RuleFor(c => c.Descricao)
                .NotNull().WithMessage("Descrição obrigatória.")
                .NotEmpty().WithMessage("Descrição obrigatória.");
        }
    }
}
