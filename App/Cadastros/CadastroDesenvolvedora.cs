using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Services.Validators;

namespace App.Cadastros
{
    public partial class CadastroDesenvolvedora : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Desenvolvedora> _desenvolvedoraService;
        private List<DesenvolvedoraModel>? desenvolvedoras;
        #endregion

        #region Construtor
        public CadastroDesenvolvedora(IBaseService<Desenvolvedora> desenvolvedoraService)
        {
            _desenvolvedoraService = desenvolvedoraService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Desenvolvedora desenvolvedora)
        {
            desenvolvedora.Nome = tbNome.Text;
            desenvolvedora.Email = tbEmail.Text;
            desenvolvedora.Site = tbSite.Text;
            desenvolvedora.Pais = tbPais.Text;
            desenvolvedora.Descricao = tbDescricao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var desenvolvedora = _desenvolvedoraService.GetById<Desenvolvedora>(id);
                        PreencheObjeto(desenvolvedora);
                        desenvolvedora = _desenvolvedoraService.Update<Desenvolvedora, Desenvolvedora, DesenvolvedoraValidator>(desenvolvedora);
                    }
                }
                else
                {
                    var desenvolvedora = new Desenvolvedora();
                    PreencheObjeto(desenvolvedora);
                    _desenvolvedoraService.Add<Desenvolvedora, Desenvolvedora, DesenvolvedoraValidator>(desenvolvedora);

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
                _desenvolvedoraService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            desenvolvedoras = _desenvolvedoraService.Get<DesenvolvedoraModel>().ToList();
            dgvConsulta.DataSource = desenvolvedoras;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
            tbEmail.Text = linha?.Cells["Email"].Value.ToString();
            tbDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            tbPais.Text = linha?.Cells["Pais"].Value.ToString();
            tbSite.Text = linha?.Cells["Site"].Value?.ToString();
        }
        #endregion
    }
}
