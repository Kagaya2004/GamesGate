using Domain.Base;
using Domain.Entities;
using ReaLTaiizor.Forms;
using Services.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Outros
{
    public partial class Login : MaterialForm
    {
        #region Declarações
        private readonly IBaseService<Usuario> _usuarioService;
        #endregion

        #region Construtor
        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObterUsuario(tbLogin.Text, tbSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Login e/ou senha incorretos!", "GamesGate",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.Status == "Inativo")
            {
                MessageBox.Show("Usuário inativo!", "GamesGate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuario.DataLogin = DateTime.Now;
                usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                FormPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        #endregion

        #region Métodos
        private Usuario? ObterUsuario(string login, string senha)
        {
            ChecaExistenciaUsuarioCadastrado();
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Login == login).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaUsuarioCadastrado()
        {
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    Login = "admin",
                    Nome = "Administrador",
                    Email = "adm@gmail.com",
                    Senha = "Administr@dor123",
                    Status = "Ativo",
                    DataNascimento = DateTime.Now,
                    DataCriacao = DateTime.Now,
                    DataLogin = DateTime.Now,
                    Descricao = "O Administrador do GamesGate"
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }

        #endregion
    }
}
