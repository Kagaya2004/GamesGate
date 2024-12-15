using App.Cadastros;
using App.Infra;
using App.Outros;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormPrincipal : MaterialForm
    {
        #region Declarações
        public static Usuario? Usuario { get; set; }
        #endregion

        #region Construtor
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }
        #endregion

        #region Métodos
        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lbUsuario.Text = $"Usuário: {Usuario.Nome}";
                }

            }
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
        #endregion

        #region Eventos
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void avaliaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAvaliacao>();
        }

        private void bibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroBiblioteca>();
        }

        private void conquistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroConquista>();
        }

        private void desenvolvedoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroDesenvolvedora>();
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroGenero>();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroJogo>();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuario>();
        }

        #endregion
    }
}
