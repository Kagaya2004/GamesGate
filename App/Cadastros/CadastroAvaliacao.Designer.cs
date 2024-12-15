namespace App.Cadastros
{
    partial class CadastroAvaliacao
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
            tbComentario = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            cbxUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxJogo = new ReaLTaiizor.Controls.MaterialComboBox();
            tbDataComentario = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbClassificacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Size = new Size(788, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbClassificacao);
            tabPageCadastro.Controls.Add(tbDataComentario);
            tabPageCadastro.Controls.Add(cbxJogo);
            tabPageCadastro.Controls.Add(cbxUsuario);
            tabPageCadastro.Controls.Add(tbComentario);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Size = new Size(780, 348);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbComentario, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxJogo, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataComentario, 0);
            tabPageCadastro.Controls.SetChildIndex(tbClassificacao, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(546, 291);
            btnCancelar.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(672, 291);
            btnSalvar.TabIndex = 6;
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
            tbId.Location = new Point(30, 30);
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
            tbId.Size = new Size(126, 48);
            tbId.TabIndex = 0;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // tbComentario
            // 
            tbComentario.AnimateReadOnly = false;
            tbComentario.BackgroundImageLayout = ImageLayout.None;
            tbComentario.CharacterCasing = CharacterCasing.Normal;
            tbComentario.Depth = 0;
            tbComentario.HideSelection = true;
            tbComentario.Hint = "Comentário";
            tbComentario.Location = new Point(30, 93);
            tbComentario.MaxLength = 32767;
            tbComentario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbComentario.Name = "tbComentario";
            tbComentario.PasswordChar = '\0';
            tbComentario.ReadOnly = false;
            tbComentario.ScrollBars = ScrollBars.None;
            tbComentario.SelectedText = "";
            tbComentario.SelectionLength = 0;
            tbComentario.SelectionStart = 0;
            tbComentario.ShortcutsEnabled = true;
            tbComentario.Size = new Size(718, 117);
            tbComentario.TabIndex = 3;
            tbComentario.TabStop = false;
            tbComentario.TextAlign = HorizontalAlignment.Left;
            tbComentario.UseSystemPasswordChar = false;
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
            cbxUsuario.Location = new Point(198, 30);
            cbxUsuario.MaxDropDownItems = 4;
            cbxUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new Size(254, 49);
            cbxUsuario.StartIndex = 0;
            cbxUsuario.TabIndex = 1;
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
            cbxJogo.Location = new Point(494, 30);
            cbxJogo.MaxDropDownItems = 4;
            cbxJogo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxJogo.Name = "cbxJogo";
            cbxJogo.Size = new Size(254, 49);
            cbxJogo.StartIndex = 0;
            cbxJogo.TabIndex = 2;
            // 
            // tbDataComentario
            // 
            tbDataComentario.AllowPromptAsInput = true;
            tbDataComentario.AnimateReadOnly = false;
            tbDataComentario.AsciiOnly = false;
            tbDataComentario.BackgroundImageLayout = ImageLayout.None;
            tbDataComentario.BeepOnError = false;
            tbDataComentario.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataComentario.Depth = 0;
            tbDataComentario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataComentario.HidePromptOnLeave = false;
            tbDataComentario.HideSelection = true;
            tbDataComentario.Hint = "Data do Comentário";
            tbDataComentario.InsertKeyMode = InsertKeyMode.Default;
            tbDataComentario.LeadingIcon = null;
            tbDataComentario.Location = new Point(463, 225);
            tbDataComentario.Mask = "99/99/9999";
            tbDataComentario.MaxLength = 32767;
            tbDataComentario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataComentario.Name = "tbDataComentario";
            tbDataComentario.PasswordChar = '\0';
            tbDataComentario.PrefixSuffixText = null;
            tbDataComentario.PromptChar = '_';
            tbDataComentario.ReadOnly = true;
            tbDataComentario.RejectInputOnFirstFailure = false;
            tbDataComentario.ResetOnPrompt = true;
            tbDataComentario.ResetOnSpace = true;
            tbDataComentario.RightToLeft = RightToLeft.No;
            tbDataComentario.SelectedText = "";
            tbDataComentario.SelectionLength = 0;
            tbDataComentario.SelectionStart = 0;
            tbDataComentario.ShortcutsEnabled = true;
            tbDataComentario.Size = new Size(285, 48);
            tbDataComentario.SkipLiterals = true;
            tbDataComentario.TabIndex = 5;
            tbDataComentario.TabStop = false;
            tbDataComentario.Text = "  /  /";
            tbDataComentario.TextAlign = HorizontalAlignment.Left;
            tbDataComentario.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataComentario.TrailingIcon = null;
            tbDataComentario.UseSystemPasswordChar = false;
            tbDataComentario.ValidatingType = null;
            // 
            // tbClassificacao
            // 
            tbClassificacao.AnimateReadOnly = false;
            tbClassificacao.AutoCompleteMode = AutoCompleteMode.None;
            tbClassificacao.AutoCompleteSource = AutoCompleteSource.None;
            tbClassificacao.BackgroundImageLayout = ImageLayout.None;
            tbClassificacao.CharacterCasing = CharacterCasing.Normal;
            tbClassificacao.Depth = 0;
            tbClassificacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbClassificacao.HideSelection = true;
            tbClassificacao.Hint = "Classificação";
            tbClassificacao.LeadingIcon = null;
            tbClassificacao.Location = new Point(30, 225);
            tbClassificacao.MaxLength = 32767;
            tbClassificacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbClassificacao.Name = "tbClassificacao";
            tbClassificacao.PasswordChar = '\0';
            tbClassificacao.PrefixSuffixText = null;
            tbClassificacao.ReadOnly = false;
            tbClassificacao.RightToLeft = RightToLeft.No;
            tbClassificacao.SelectedText = "";
            tbClassificacao.SelectionLength = 0;
            tbClassificacao.SelectionStart = 0;
            tbClassificacao.ShortcutsEnabled = true;
            tbClassificacao.Size = new Size(422, 48);
            tbClassificacao.TabIndex = 4;
            tbClassificacao.TabStop = false;
            tbClassificacao.TextAlign = HorizontalAlignment.Left;
            tbClassificacao.TrailingIcon = null;
            tbClassificacao.UseSystemPasswordChar = false;
            // 
            // CadastroAvaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroAvaliacao";
            Text = "Cadastro de Avaliação";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox cbxJogo;
        private ReaLTaiizor.Controls.MaterialComboBox cbxUsuario;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit tbComentario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataComentario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbClassificacao;
    }
}