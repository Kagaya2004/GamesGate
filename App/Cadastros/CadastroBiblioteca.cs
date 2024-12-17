using App.Base;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Services.Validators;
using System.Globalization;

namespace App.Cadastros
{
    public partial class CadastroBiblioteca : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Biblioteca> _bibliotecaService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Jogo> _jogoService;
        private List<BibliotecaItemModel> bibliotecaJogos;
        private List<BibliotecaModel>? bibliotecas;
        #endregion

        #region Construtor
        public CadastroBiblioteca(IBaseService<Biblioteca> bibliotecaService,
            IBaseService<Usuario> usuarioService,
            IBaseService<Jogo> jogoService)
        {
            _bibliotecaService = bibliotecaService;
            _usuarioService = usuarioService;
            _jogoService = jogoService;
            bibliotecaJogos = new List<BibliotecaItemModel>();
            InitializeComponent();
            CarregaComboBox();
            CarregaGridJogos();
            Novo();
        }
        #endregion

        #region Métodos
        private void CarregaComboBox()
        {
            cbxUsuario.ValueMember = "Id";
            cbxUsuario.DisplayMember = "Nome";
            cbxUsuario.DataSource = _usuarioService.Get<Usuario>().ToList();

            cbxJogo.ValueMember = "Id";
            cbxJogo.DisplayMember = "Nome";
            cbxJogo.DataSource = _jogoService.Get<Jogo>().ToList();
        }

        private void PreencheObjeto(Biblioteca biblioteca)
        {
            if (int.TryParse(cbxUsuario.SelectedValue.ToString(), out var idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                biblioteca.Usuario = usuario;
            }

            foreach (var jogo in bibliotecaJogos)
            {
                var jogoBiblioteca = new BibliotecaItem
                {
                    Biblioteca = biblioteca,
                    Jogo = _jogoService.GetById<Jogo>(jogo.IdJogo),
                    HorasJogadas = jogo.HorasJogadas,
                };
                biblioteca.ListaJogos.Add(jogoBiblioteca);
            }

        }

        protected override void Novo()
        {
            base.Novo();
            bibliotecaJogos.Clear();
            CarregaGridJogos();
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(tbId.Text, out var id))
                    {
                        var biblioteca = _bibliotecaService.GetById<Biblioteca>(id);
                        PreencheObjeto(biblioteca);
                        biblioteca = _bibliotecaService.Update<Biblioteca, Biblioteca, BibliotecaValidator>(biblioteca);
                    }
                }
                else
                {
                    var biblioteca = new Biblioteca();
                    PreencheObjeto(biblioteca);
                    biblioteca = _bibliotecaService.Add<Biblioteca, Biblioteca, BibliotecaValidator>(biblioteca);
                }

                tabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Excluir(int id)
        {
            try
            {
                _bibliotecaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GamesGate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Usuario" };
            bibliotecas = _bibliotecaService.Get<BibliotecaModel>(false, includes).ToList();
            dgvConsulta.DataSource = bibliotecas;
            dgvConsulta.Columns["IdUsuario"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            tbId.Text = linha?.Cells["Id"].Value.ToString();
            cbxUsuario.SelectedValue = linha?.Cells["IdUsuario"].Value;

            var includes = new List<string>() { "Usuario", "ListaJogos", "ListaJogos.Jogo" };
            var biblioteca = _bibliotecaService.GetById<Biblioteca>(id, true, includes);
            bibliotecaJogos = new List<BibliotecaItemModel>();
            foreach (var jogoBiblioteca in biblioteca.ListaJogos)
            {
                var jogo = new BibliotecaItemModel
                {
                    Id = jogoBiblioteca.Id,
                    IdJogo = jogoBiblioteca.Jogo!.Id,
                    Jogo = jogoBiblioteca.Jogo!.Nome,
                    HorasJogadas = jogoBiblioteca.HorasJogadas,
                };
                bibliotecaJogos.Add(jogo);
            }
            CarregaGridJogos();

        }

        private void CarregaGridJogos()
        {
            var source = new BindingSource();
            source.DataSource = bibliotecaJogos.ToArray();
            dgvJogos.DataSource = source;
            dgvJogos.Columns["Id"]!.Visible = false;
            dgvJogos.Columns["IdJogo"]!.HeaderText = @"Id.Jogo";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var jogoBiblioteca = new BibliotecaItemModel();
                if (int.TryParse(cbxJogo.SelectedValue.ToString(), out var idJogo))
                {
                    var jogo = _jogoService.GetById<Jogo>(idJogo);
                    jogoBiblioteca.IdJogo = jogo.Id;
                    jogoBiblioteca.Jogo = jogo.Nome;
                }

                if (float.TryParse(tbHorasJogadas.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var horasJogadas))
                {
                    jogoBiblioteca.HorasJogadas = horasJogadas;
                }

                bibliotecaJogos.Add(jogoBiblioteca);
                CarregaGridJogos();
            }
        }

        private bool ValidaItem()
        {
            return true;
        }

        #endregion

    }
}
