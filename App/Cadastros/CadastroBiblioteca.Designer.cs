namespace App.Cadastros
{
    partial class CadastroBiblioteca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            gbJogos = new GroupBox();
            dgvJogos = new DataGridView();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            tbHorasJogadas = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxJogo = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            gbJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJogos).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Size = new Size(738, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(gbJogos);
            tabPageCadastro.Controls.Add(cbxUsuario);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Size = new Size(730, 348);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(gbJogos, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(513, 303);
            btnCancelar.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(626, 303);
            btnSalvar.TabIndex = 3;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(453, 293);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(543, 293);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(633, 293);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(730, 348);
            // 
            // tbId
            // 
            tbId.AnimateReadOnly = false;
            tbId.AutoCompleteMode = AutoCompleteMode.None;
            tbId.AutoCompleteSource = AutoCompleteSource.None;
            tbId.BackgroundImageLayout = ImageLayout.None;
            tbId.CharacterCasing = CharacterCasing.Normal;
            tbId.Depth = 0;
            tbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbId.HideSelection = true;
            tbId.Hint = "ID da Biblioteca";
            tbId.LeadingIcon = null;
            tbId.Location = new Point(22, 22);
            tbId.MaxLength = 32767;
            tbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbId.Name = "tbId";
            tbId.PasswordChar = '\0';
            tbId.PrefixSuffixText = null;
            tbId.ReadOnly = true;
            tbId.RightToLeft = RightToLeft.No;
            tbId.SelectedText = "";
            tbId.SelectionLength = 0;
            tbId.SelectionStart = 0;
            tbId.ShortcutsEnabled = true;
            tbId.Size = new Size(158, 48);
            tbId.TabIndex = 1;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // cbxUsuario
            // 
            cbxUsuario.AutoResize = false;
            cbxUsuario.BackColor = Color.FromArgb(255, 255, 255);
            cbxUsuario.Depth = 0;
            cbxUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            cbxUsuario.DropDownHeight = 174;
            cbxUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUsuario.DropDownWidth = 121;
            cbxUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxUsuario.FormattingEnabled = true;
            cbxUsuario.Hint = "Usuário";
            cbxUsuario.IntegralHeight = false;
            cbxUsuario.ItemHeight = 43;
            cbxUsuario.Location = new Point(201, 22);
            cbxUsuario.MaxDropDownItems = 4;
            cbxUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new Size(521, 49);
            cbxUsuario.StartIndex = 0;
            cbxUsuario.TabIndex = 2;
            // 
            // gbJogos
            // 
            gbJogos.Controls.Add(dgvJogos);
            gbJogos.Controls.Add(btnAdicionar);
            gbJogos.Controls.Add(tbHorasJogadas);
            gbJogos.Controls.Add(cbxJogo);
            gbJogos.Location = new Point(16, 86);
            gbJogos.Name = "gbJogos";
            gbJogos.Size = new Size(712, 208);
            gbJogos.TabIndex = 4;
            gbJogos.TabStop = false;
            gbJogos.Text = "Jogo da Biblioteca";
            // 
            // dgvJogos
            // 
            dgvJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJogos.Location = new Point(6, 82);
            dgvJogos.Name = "dgvJogos";
            dgvJogos.Size = new Size(700, 120);
            dgvJogos.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(641, 37);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(64, 36);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "+";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // tbHorasJogadas
            // 
            tbHorasJogadas.AnimateReadOnly = false;
            tbHorasJogadas.AutoCompleteMode = AutoCompleteMode.None;
            tbHorasJogadas.AutoCompleteSource = AutoCompleteSource.None;
            tbHorasJogadas.BackgroundImageLayout = ImageLayout.None;
            tbHorasJogadas.CharacterCasing = CharacterCasing.Normal;
            tbHorasJogadas.Depth = 0;
            tbHorasJogadas.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbHorasJogadas.HideSelection = true;
            tbHorasJogadas.Hint = "Horas Jogadas";
            tbHorasJogadas.LeadingIcon = null;
            tbHorasJogadas.Location = new Point(452, 28);
            tbHorasJogadas.MaxLength = 32767;
            tbHorasJogadas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbHorasJogadas.Name = "tbHorasJogadas";
            tbHorasJogadas.PasswordChar = '\0';
            tbHorasJogadas.PrefixSuffixText = null;
            tbHorasJogadas.ReadOnly = false;
            tbHorasJogadas.RightToLeft = RightToLeft.No;
            tbHorasJogadas.SelectedText = "";
            tbHorasJogadas.SelectionLength = 0;
            tbHorasJogadas.SelectionStart = 0;
            tbHorasJogadas.ShortcutsEnabled = true;
            tbHorasJogadas.Size = new Size(177, 48);
            tbHorasJogadas.TabIndex = 1;
            tbHorasJogadas.TabStop = false;
            tbHorasJogadas.TextAlign = HorizontalAlignment.Left;
            tbHorasJogadas.TrailingIcon = null;
            tbHorasJogadas.UseSystemPasswordChar = false;
            // 
            // cbxJogo
            // 
            cbxJogo.AutoResize = false;
            cbxJogo.BackColor = Color.FromArgb(255, 255, 255);
            cbxJogo.Depth = 0;
            cbxJogo.DrawMode = DrawMode.OwnerDrawVariable;
            cbxJogo.DropDownHeight = 174;
            cbxJogo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxJogo.DropDownWidth = 121;
            cbxJogo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxJogo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxJogo.FormattingEnabled = true;
            cbxJogo.Hint = "Jogo";
            cbxJogo.IntegralHeight = false;
            cbxJogo.ItemHeight = 43;
            cbxJogo.Location = new Point(6, 27);
            cbxJogo.MaxDropDownItems = 4;
            cbxJogo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxJogo.Name = "cbxJogo";
            cbxJogo.Size = new Size(434, 49);
            cbxJogo.StartIndex = 0;
            cbxJogo.TabIndex = 0;
            // 
            // CadastroBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 450);
            Location = new Point(0, 0);
            Name = "CadastroBiblioteca";
            Text = "Cadastro de Biblioteca";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            gbJogos.ResumeLayout(false);
            gbJogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJogos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialComboBox cbxUsuario;
        private GroupBox gbJogos;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbHorasJogadas;
        private ReaLTaiizor.Controls.MaterialComboBox cbxJogo;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
        private DataGridView dgvJogos;
        private ReaLTaiizor.Controls.MaterialButton btnLimpar;
    }
}