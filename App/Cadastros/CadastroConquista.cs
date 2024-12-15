using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Services.Validators;

namespace App.Cadastros
{
    public partial class CadastroConquista : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Conquista> _conquistaService;
        private readonly IBaseService<Jogo> _jogoService;
        private List<ConquistaModel>? conquistas;
        #endregion

        #region Construtor
        public CadastroConquista(IBaseService<Conquista> conquistaService, IBaseService<Jogo> jogoService)
        {
            _conquistaService = conquistaService;
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
        }

        private void PreencheObjeto(Conquista conquista)
        {
            if (int.TryParse(cbxJogo.SelectedValue.ToString(), out int idJogo))
            {
                var jogo = _jogoService.GetById<Jogo>(idJogo);
                conquista.Jogo = jogo;
            }
            conquista.Descricao = tbDescricao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var conquista = _conquistaService.GetById<Conquista>(id);
                        PreencheObjeto(conquista);
                        conquista = _conquistaService.Update<Conquista, Conquista, ConquistaValidator>(conquista);
                    }
                }
                else
                {
                    var conquista = new Conquista();
                    PreencheObjeto(conquista);
                    _conquistaService.Add<Conquista, Conquista, ConquistaValidator>(conquista);

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
                _conquistaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            conquistas = _conquistaService.Get<ConquistaModel>().ToList();
            dgvConsulta.DataSource = conquistas;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            cbxJogo.SelectedValue = linha?.Cells["IdJogo"].Value;
        }
        #endregion
    }
}
