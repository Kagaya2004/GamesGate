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
    public partial class CadastroJogo : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Jogo> _jogoService;
        private readonly IBaseService<Desenvolvedora> _desenvolvedoraService;
        private List<JogoModel>? jogos;
        #endregion

        #region Construtor
        public CadastroJogo(IBaseService<Jogo> jogoService, IBaseService<Desenvolvedora> desenvolvedoraService)
        {
            _jogoService = jogoService;
            _desenvolvedoraService = desenvolvedoraService;
            InitializeComponent();
            CarregaComboBox();
        }
        #endregion

        #region Métodos
        private void CarregaComboBox()
        {
            cbxDesenvolvedora.ValueMember = "Id";
            cbxDesenvolvedora.DisplayMember = "Nome";
            cbxDesenvolvedora.DataSource = _desenvolvedoraService.Get<DesenvolvedoraModel>().ToList();
        }

        private void PreencheObjeto(Jogo jogo)
        {
            if (int.TryParse(cbxDesenvolvedora.SelectedValue.ToString(), out int idDesenvolvedora))
            {
                var desenvolvedora = _desenvolvedoraService.GetById<Desenvolvedora>(idDesenvolvedora);
                jogo.Desenvolvedora = desenvolvedora;
            }
            jogo.Nome = tbNome.Text;
            jogo.DataLancamento = DateTime.Parse(tbDataLancamento.Text);
            jogo.Descricao = tbDescricao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var jogo = _jogoService.GetById<Jogo>(id);
                        PreencheObjeto(jogo);
                        jogo = _jogoService.Update<Jogo, Jogo, JogoValidator>(jogo);
                    }
                }
                else
                {
                    var jogo = new Jogo();
                    PreencheObjeto(jogo);
                    _jogoService.Add<Jogo, Jogo, JogoValidator>(jogo);

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
            jogos = _jogoService.Get<JogoModel>().ToList();
            dgvConsulta.DataSource = jogos;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
            cbxDesenvolvedora.SelectedValue = linha?.Cells["IdDesenvolvedora"].Value;
            tbDataLancamento.Text = linha?.Cells["DataLancamento"].Value.ToString();
            tbDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
        }
        # endregion
    }
}
