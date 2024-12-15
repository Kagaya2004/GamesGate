namespace App.Cadastros
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            tbSenha = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbDataLogin = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbDataCriacao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbDescricao = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Size = new Size(733, 388);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbDescricao);
            tabPageCadastro.Controls.Add(tbDataNascimento);
            tabPageCadastro.Controls.Add(tbDataLogin);
            tabPageCadastro.Controls.Add(tbDataCriacao);
            tabPageCadastro.Controls.Add(tbSenha);
            tabPageCadastro.Controls.Add(cbxStatus);
            tabPageCadastro.Controls.Add(tbEmail);
            tabPageCadastro.Controls.Add(tbLogin);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Size = new Size(725, 353);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbNome, 0);
            tabPageCadastro.Controls.SetChildIndex(tbLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(tbEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxStatus, 0);
            tabPageCadastro.Controls.SetChildIndex(tbSenha, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataCriacao, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataNascimento, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDescricao, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(515, 308);
            btnCancelar.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(632, 308);
            btnSalvar.TabIndex = 10;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(448, 298);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(538, 298);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(628, 298);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(725, 353);
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
            tbId.Hint = "ID";
            tbId.LeadingIcon = null;
            tbId.Location = new Point(28, 15);
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
            tbId.Size = new Size(88, 48);
            tbId.TabIndex = 0;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // tbNome
            // 
            tbNome.AnimateReadOnly = false;
            tbNome.AutoCompleteMode = AutoCompleteMode.None;
            tbNome.AutoCompleteSource = AutoCompleteSource.None;
            tbNome.BackgroundImageLayout = ImageLayout.None;
            tbNome.CharacterCasing = CharacterCasing.Normal;
            tbNome.Depth = 0;
            tbNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbNome.HideSelection = true;
            tbNome.Hint = "Nome";
            tbNome.LeadingIcon = null;
            tbNome.Location = new Point(28, 79);
            tbNome.MaxLength = 32767;
            tbNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbNome.Name = "tbNome";
            tbNome.PasswordChar = '\0';
            tbNome.PrefixSuffixText = null;
            tbNome.ReadOnly = false;
            tbNome.RightToLeft = RightToLeft.No;
            tbNome.SelectedText = "";
            tbNome.SelectionLength = 0;
            tbNome.SelectionStart = 0;
            tbNome.ShortcutsEnabled = true;
            tbNome.Size = new Size(305, 48);
            tbNome.TabIndex = 5;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // tbLogin
            // 
            tbLogin.AnimateReadOnly = false;
            tbLogin.AutoCompleteMode = AutoCompleteMode.None;
            tbLogin.AutoCompleteSource = AutoCompleteSource.None;
            tbLogin.BackgroundImageLayout = ImageLayout.None;
            tbLogin.CharacterCasing = CharacterCasing.Normal;
            tbLogin.Depth = 0;
            tbLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbLogin.HideSelection = true;
            tbLogin.Hint = "Login";
            tbLogin.LeadingIcon = null;
            tbLogin.Location = new Point(358, 79);
            tbLogin.MaxLength = 32767;
            tbLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbLogin.Name = "tbLogin";
            tbLogin.PasswordChar = '\0';
            tbLogin.PrefixSuffixText = null;
            tbLogin.ReadOnly = false;
            tbLogin.RightToLeft = RightToLeft.No;
            tbLogin.SelectedText = "";
            tbLogin.SelectionLength = 0;
            tbLogin.SelectionStart = 0;
            tbLogin.ShortcutsEnabled = true;
            tbLogin.Size = new Size(346, 48);
            tbLogin.TabIndex = 6;
            tbLogin.TabStop = false;
            tbLogin.TextAlign = HorizontalAlignment.Left;
            tbLogin.TrailingIcon = null;
            tbLogin.UseSystemPasswordChar = false;
            // 
            // tbEmail
            // 
            tbEmail.AnimateReadOnly = false;
            tbEmail.AutoCompleteMode = AutoCompleteMode.None;
            tbEmail.AutoCompleteSource = AutoCompleteSource.None;
            tbEmail.BackgroundImageLayout = ImageLayout.None;
            tbEmail.CharacterCasing = CharacterCasing.Normal;
            tbEmail.Depth = 0;
            tbEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmail.HideSelection = true;
            tbEmail.Hint = "Email";
            tbEmail.LeadingIcon = null;
            tbEmail.Location = new Point(28, 143);
            tbEmail.MaxLength = 32767;
            tbEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEmail.Name = "tbEmail";
            tbEmail.PasswordChar = '\0';
            tbEmail.PrefixSuffixText = null;
            tbEmail.ReadOnly = false;
            tbEmail.RightToLeft = RightToLeft.No;
            tbEmail.SelectedText = "";
            tbEmail.SelectionLength = 0;
            tbEmail.SelectionStart = 0;
            tbEmail.ShortcutsEnabled = true;
            tbEmail.Size = new Size(305, 48);
            tbEmail.TabIndex = 7;
            tbEmail.TabStop = false;
            tbEmail.TextAlign = HorizontalAlignment.Left;
            tbEmail.TrailingIcon = null;
            tbEmail.UseSystemPasswordChar = false;
            // 
            // cbxStatus
            // 
            cbxStatus.AutoResize = false;
            cbxStatus.BackColor = Color.FromArgb(255, 255, 255);
            cbxStatus.Depth = 0;
            cbxStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cbxStatus.DropDownHeight = 174;
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.DropDownWidth = 121;
            cbxStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Hint = "Status";
            cbxStatus.IntegralHeight = false;
            cbxStatus.ItemHeight = 43;
            cbxStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbxStatus.Location = new Point(583, 15);
            cbxStatus.MaxDropDownItems = 4;
            cbxStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(124, 49);
            cbxStatus.StartIndex = 0;
            cbxStatus.TabIndex = 4;
            // 
            // tbSenha
            // 
            tbSenha.AllowPromptAsInput = true;
            tbSenha.AnimateReadOnly = false;
            tbSenha.AsciiOnly = false;
            tbSenha.BackgroundImageLayout = ImageLayout.None;
            tbSenha.BeepOnError = false;
            tbSenha.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbSenha.Depth = 0;
            tbSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSenha.HidePromptOnLeave = false;
            tbSenha.HideSelection = true;
            tbSenha.Hint = "Senha";
            tbSenha.InsertKeyMode = InsertKeyMode.Default;
            tbSenha.LeadingIcon = (Image)resources.GetObject("tbSenha.LeadingIcon");
            tbSenha.Location = new Point(358, 145);
            tbSenha.Mask = "";
            tbSenha.MaxLength = 32767;
            tbSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.PrefixSuffixText = null;
            tbSenha.PromptChar = '_';
            tbSenha.ReadOnly = false;
            tbSenha.RejectInputOnFirstFailure = false;
            tbSenha.ResetOnPrompt = true;
            tbSenha.ResetOnSpace = true;
            tbSenha.RightToLeft = RightToLeft.No;
            tbSenha.SelectedText = "";
            tbSenha.SelectionLength = 0;
            tbSenha.SelectionStart = 0;
            tbSenha.ShortcutsEnabled = true;
            tbSenha.Size = new Size(346, 48);
            tbSenha.SkipLiterals = true;
            tbSenha.TabIndex = 8;
            tbSenha.TabStop = false;
            tbSenha.TextAlign = HorizontalAlignment.Left;
            tbSenha.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbSenha.TrailingIcon = null;
            tbSenha.UseSystemPasswordChar = false;
            tbSenha.ValidatingType = null;
            // 
            // tbDataLogin
            // 
            tbDataLogin.AllowPromptAsInput = true;
            tbDataLogin.AnimateReadOnly = false;
            tbDataLogin.AsciiOnly = false;
            tbDataLogin.BackgroundImageLayout = ImageLayout.None;
            tbDataLogin.BeepOnError = false;
            tbDataLogin.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataLogin.Depth = 0;
            tbDataLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataLogin.HidePromptOnLeave = false;
            tbDataLogin.HideSelection = true;
            tbDataLogin.Hint = "Data de Login";
            tbDataLogin.InsertKeyMode = InsertKeyMode.Default;
            tbDataLogin.LeadingIcon = null;
            tbDataLogin.Location = new Point(449, 15);
            tbDataLogin.Mask = "99/99/9999";
            tbDataLogin.MaxLength = 32767;
            tbDataLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataLogin.Name = "tbDataLogin";
            tbDataLogin.PasswordChar = '\0';
            tbDataLogin.PrefixSuffixText = null;
            tbDataLogin.PromptChar = '_';
            tbDataLogin.ReadOnly = true;
            tbDataLogin.RejectInputOnFirstFailure = false;
            tbDataLogin.ResetOnPrompt = true;
            tbDataLogin.ResetOnSpace = true;
            tbDataLogin.RightToLeft = RightToLeft.No;
            tbDataLogin.SelectedText = "";
            tbDataLogin.SelectionLength = 0;
            tbDataLogin.SelectionStart = 0;
            tbDataLogin.ShortcutsEnabled = true;
            tbDataLogin.Size = new Size(114, 48);
            tbDataLogin.SkipLiterals = true;
            tbDataLogin.TabIndex = 3;
            tbDataLogin.TabStop = false;
            tbDataLogin.Text = "  /  /";
            tbDataLogin.TextAlign = HorizontalAlignment.Left;
            tbDataLogin.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataLogin.TrailingIcon = null;
            tbDataLogin.UseSystemPasswordChar = false;
            tbDataLogin.ValidatingType = null;
            // 
            // tbDataCriacao
            // 
            tbDataCriacao.AllowPromptAsInput = true;
            tbDataCriacao.AnimateReadOnly = false;
            tbDataCriacao.AsciiOnly = false;
            tbDataCriacao.BackgroundImageLayout = ImageLayout.None;
            tbDataCriacao.BeepOnError = false;
            tbDataCriacao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataCriacao.Depth = 0;
            tbDataCriacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataCriacao.HidePromptOnLeave = false;
            tbDataCriacao.HideSelection = true;
            tbDataCriacao.Hint = "Data de Criação";
            tbDataCriacao.InsertKeyMode = InsertKeyMode.Default;
            tbDataCriacao.LeadingIcon = null;
            tbDataCriacao.Location = new Point(301, 15);
            tbDataCriacao.Mask = "99/99/9999";
            tbDataCriacao.MaxLength = 32767;
            tbDataCriacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataCriacao.Name = "tbDataCriacao";
            tbDataCriacao.PasswordChar = '\0';
            tbDataCriacao.PrefixSuffixText = null;
            tbDataCriacao.PromptChar = '_';
            tbDataCriacao.ReadOnly = true;
            tbDataCriacao.RejectInputOnFirstFailure = false;
            tbDataCriacao.ResetOnPrompt = true;
            tbDataCriacao.ResetOnSpace = true;
            tbDataCriacao.RightToLeft = RightToLeft.No;
            tbDataCriacao.SelectedText = "";
            tbDataCriacao.SelectionLength = 0;
            tbDataCriacao.SelectionStart = 0;
            tbDataCriacao.ShortcutsEnabled = true;
            tbDataCriacao.Size = new Size(128, 48);
            tbDataCriacao.SkipLiterals = true;
            tbDataCriacao.TabIndex = 2;
            tbDataCriacao.TabStop = false;
            tbDataCriacao.Text = "  /  /";
            tbDataCriacao.TextAlign = HorizontalAlignment.Left;
            tbDataCriacao.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataCriacao.TrailingIcon = null;
            tbDataCriacao.UseSystemPasswordChar = false;
            tbDataCriacao.ValidatingType = null;
            // 
            // tbDataNascimento
            // 
            tbDataNascimento.AllowPromptAsInput = true;
            tbDataNascimento.AnimateReadOnly = false;
            tbDataNascimento.AsciiOnly = false;
            tbDataNascimento.BackgroundImageLayout = ImageLayout.None;
            tbDataNascimento.BeepOnError = false;
            tbDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataNascimento.Depth = 0;
            tbDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataNascimento.HidePromptOnLeave = false;
            tbDataNascimento.HideSelection = true;
            tbDataNascimento.Hint = "Data de Nascimento";
            tbDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            tbDataNascimento.LeadingIcon = null;
            tbDataNascimento.Location = new Point(136, 15);
            tbDataNascimento.Mask = "99/99/9999";
            tbDataNascimento.MaxLength = 32767;
            tbDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataNascimento.Name = "tbDataNascimento";
            tbDataNascimento.PasswordChar = '\0';
            tbDataNascimento.PrefixSuffixText = null;
            tbDataNascimento.PromptChar = '_';
            tbDataNascimento.ReadOnly = false;
            tbDataNascimento.RejectInputOnFirstFailure = false;
            tbDataNascimento.ResetOnPrompt = true;
            tbDataNascimento.ResetOnSpace = true;
            tbDataNascimento.RightToLeft = RightToLeft.No;
            tbDataNascimento.SelectedText = "";
            tbDataNascimento.SelectionLength = 0;
            tbDataNascimento.SelectionStart = 0;
            tbDataNascimento.ShortcutsEnabled = true;
            tbDataNascimento.Size = new Size(145, 48);
            tbDataNascimento.SkipLiterals = true;
            tbDataNascimento.TabIndex = 1;
            tbDataNascimento.TabStop = false;
            tbDataNascimento.Text = "  /  /";
            tbDataNascimento.TextAlign = HorizontalAlignment.Left;
            tbDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataNascimento.TrailingIcon = null;
            tbDataNascimento.UseSystemPasswordChar = false;
            tbDataNascimento.ValidatingType = null;
            // 
            // tbDescricao
            // 
            tbDescricao.AnimateReadOnly = false;
            tbDescricao.BackgroundImageLayout = ImageLayout.None;
            tbDescricao.CharacterCasing = CharacterCasing.Normal;
            tbDescricao.Depth = 0;
            tbDescricao.HideSelection = true;
            tbDescricao.Hint = "Descrição";
            tbDescricao.Location = new Point(29, 207);
            tbDescricao.MaxLength = 32767;
            tbDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.PasswordChar = '\0';
            tbDescricao.ReadOnly = false;
            tbDescricao.ScrollBars = ScrollBars.None;
            tbDescricao.SelectedText = "";
            tbDescricao.SelectionLength = 0;
            tbDescricao.SelectionStart = 0;
            tbDescricao.ShortcutsEnabled = true;
            tbDescricao.Size = new Size(675, 91);
            tbDescricao.TabIndex = 9;
            tbDescricao.TabStop = false;
            tbDescricao.TextAlign = HorizontalAlignment.Left;
            tbDescricao.UseSystemPasswordChar = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 466);
            Location = new Point(0, 0);
            Name = "CadastroUsuario";
            Text = "Cadastro de Usuário";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbLogin;
        private ReaLTaiizor.Controls.MaterialComboBox cbxStatus;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbSenha;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataLogin;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataNascimento;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataCriacao;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit tbDescricao;
    }
}