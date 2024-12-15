using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
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

namespace App.Cadastros
{
    public partial class CadastroJogoGenero : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<JogoGenero> _jogoGeneroService;
        private readonly IBaseService<Jogo> _jogoService;
        private readonly IBaseService<Genero> _generoService;
        private List<JogoGeneroModel>? jogoGeneros;
        #endregion

        #region Construtor
        public CadastroJogoGenero(IBaseService<JogoGenero> jogoGeneroService,
            IBaseService<Jogo> jogoService, IBaseService<Genero> generoService)
        {
            _jogoGeneroService = jogoGeneroService;
            _jogoService = jogoService;
            _generoService = generoService;
            InitializeComponent();
            CarregaComboBox();
        }
        #endregion

        #region Métodos
        private void CarregaComboBox()
        {
            cbxJogo.ValueMember = "Id";
            cbxJogo.DisplayMember = "Nome";
            cbxJogo.DataSource = _jogoService.Get<JogoModel>().ToList();

            cbxGenero.ValueMember = "Id";
            cbxGenero.DisplayMember = "Nome";
            cbxGenero.DataSource = _generoService.Get<GeneroModel>().ToList();
        }

        private void PreencheObjeto(JogoGenero jogoGenero)
        {
            if (int.TryParse(cbxJogo.SelectedValue.ToString(), out int idJogo))
            {
                var jogo = _jogoService.GetById<Jogo>(idJogo);
                jogoGenero.Jogo = jogo;
            }
            if (int.TryParse(cbxGenero.SelectedValue.ToString(), out int idGenero))
            {
                var genero = _generoService.GetById<Genero>(idGenero);
                jogoGenero.Genero = genero;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var jogoGenero = _jogoGeneroService.GetById<JogoGenero>(id);
                        PreencheObjeto(jogoGenero);
                        jogoGenero = _jogoGeneroService.Update<JogoGenero, JogoGenero, JogoGeneroValidator>(jogoGenero);
                    }
                }
                else
                {
                    var jogoGenero = new JogoGenero();
                    PreencheObjeto(jogoGenero);
                    _jogoGeneroService.Add<JogoGenero, JogoGenero, JogoGeneroValidator>(jogoGenero);

                }

                tabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Excluir(int id)
        {
            try
            {
                _jogoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            jogoGeneros = _jogoGeneroService.Get<JogoGeneroModel>().ToList();
            dgvConsulta.DataSource = jogoGeneros;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            cbxJogo.SelectedValue = linha?.Cells["IdJogo"].Value;
            cbxGenero.SelectedValue = linha?.Cells["IdGenero"].Value;
        }
        # endregion
    }
}
