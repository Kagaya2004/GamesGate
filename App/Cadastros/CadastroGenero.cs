using App.Base;
using App.Models;
using App.Outros;
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
    public partial class CadastroGenero : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Genero> _generoService;
        private List<GeneroModel>? generos;
        #endregion

        #region Construtor
        public CadastroGenero(IBaseService<Genero> generoService)
        {
            _generoService = generoService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Genero genero)
        {
            genero.Nome = tbNome.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var genero = _generoService.GetById<Genero>(id);
                        PreencheObjeto(genero);
                        genero = _generoService.Update<Genero, Genero, GeneroValidator>(genero);
                    }
                }
                else
                {
                    var genero = new Genero();
                    PreencheObjeto(genero);
                    _generoService.Add<Genero, Genero, GeneroValidator>(genero);

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
                _generoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            generos = _generoService.Get<GeneroModel>().ToList();
            dgvConsulta.DataSource = generos;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
        }
        #endregion
    }
}
