using App.Infra;
using App.Outros;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        public void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
            tabControl.SelectedIndex = 0;
            tabControl.Focus();
        }

        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dgvConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dgvConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                tabControl.SelectedIndex = 0;
                tabControl.Focus();
            }
        }

        protected virtual void Excluir(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }

        #endregion

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar", @"GamesGate",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControl.SelectedIndex = 0;

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir", @"GamesGate",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dgvConsulta.SelectedRows[0].Cells["Id"].Value;
                    Excluir(id);
                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show(@"Selecione algum registro", @"GamesGate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void tabPageConsulta_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        #endregion
    }
}
