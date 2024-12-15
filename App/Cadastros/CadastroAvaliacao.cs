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
    public partial class CadastroAvaliacao : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Avaliacao> _avaliacaoService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Jogo> _jogoService;
        private List<AvaliacaoModel>? avaliacoes;
        #endregion

        #region Construtor
        public CadastroAvaliacao(IBaseService<Avaliacao> avaliacaoService, 
            IBaseService<Usuario> usuarioService,
            IBaseService<Jogo> jogoService)
        {
            _avaliacaoService = avaliacaoService;
            _usuarioService = usuarioService;
            _jogoService = jogoService;
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

            cbxUsuario.ValueMember = "Id";
            cbxUsuario.DisplayMember = "Nome";
            cbxUsuario.DataSource = _usuarioService.Get<UsuarioModel>().ToList();
        }

        private void PreencheObjeto(Avaliacao avaliacao)
        {
            if (int.TryParse(cbxJogo.SelectedValue.ToString(), out int idJogo))
            {
                var jogo = _jogoService.GetById<Jogo>(idJogo);
                avaliacao.Jogo = jogo;
            }
            if (int.TryParse(cbxUsuario.SelectedValue.ToString(), out int idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                avaliacao.Usuario = usuario;
            }
            if (float.TryParse(tbClassificacao.Text, out float feedback))
            {
                avaliacao.Classificacao = feedback;
            }
            avaliacao.Comentario = tbComentario.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var avaliacao = _avaliacaoService.GetById<Avaliacao>(id);
                        PreencheObjeto(avaliacao);
                        avaliacao = _avaliacaoService.Update<Avaliacao, Avaliacao, AvaliacaoValidator>(avaliacao);
                    }
                }
                else
                {
                    var avaliacao = new Avaliacao();
                    PreencheObjeto(avaliacao);
                    _avaliacaoService.Add<Avaliacao, Avaliacao, AvaliacaoValidator>(avaliacao);

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
                _avaliacaoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            avaliacoes = _avaliacaoService.Get<AvaliacaoModel>().ToList();
            dgvConsulta.DataSource = avaliacoes;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            cbxJogo.SelectedValue = linha?.Cells["IdJogo"].Value;
            cbxUsuario.SelectedValue = linha?.Cells["IdUsuario"].Value;
            tbComentario.Text = linha?.Cells["Comentario"].Value.ToString();
            tbDataComentario.Text = DateTime.TryParse(linha?.Cells["DataComentario"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";
            tbClassificacao.Text = linha?.Cells["Classificacao"].Value.ToString();
        }
        # endregion
    }
}
