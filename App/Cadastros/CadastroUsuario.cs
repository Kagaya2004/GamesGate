using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Services.Validators;

namespace App.Cadastros
{
    public partial class CadastroUsuario : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Usuario> _usuarioService;
        private List<UsuarioModel>? usuarios;
        #endregion

        #region Construtor
        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = tbNome.Text;
            usuario.Email = tbEmail.Text;
            usuario.Login = tbLogin.Text;
            usuario.Status = cbxStatus.Text;
            usuario.Senha = tbSenha.Text;
            usuario.Descricao = tbDescricao.Text;
            usuario.DataNascimento = DateTime.Parse(tbDataNascimento.Text);
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);

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
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<UsuarioModel>().ToList();
            dgvConsulta.DataSource = usuarios;
            dgvConsulta.Columns["Senha"]!.Visible = false;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            tbNome.Text = linha?.Cells["Nome"].Value.ToString();
            tbEmail.Text = linha?.Cells["Email"].Value.ToString();
            tbLogin.Text = linha?.Cells["Login"].Value.ToString();
            tbSenha.Text = linha?.Cells["Senha"].Value.ToString();
            cbxStatus.Text = linha?.Cells["Status"].Value.ToString();
            tbDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            tbDataNascimento.Text = linha?.Cells["DataNascimento"].Value.ToString();

            tbDataCriacao.Text = DateTime.TryParse(linha?.Cells["DataCriacao"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";

            tbDataLogin.Text = DateTime.TryParse(linha?.Cells["DataLogin"].Value.ToString(), out var dataL)
                ? dataL.ToString("g")
                : "";
        }

        #endregion
    }
}
