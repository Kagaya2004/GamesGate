namespace App.Cadastros
{
    partial class CadastroJogo
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
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxDesenvolvedora = new ReaLTaiizor.Controls.MaterialComboBox();
            tbDataLancamento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbDescricao = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
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
            tabPageCadastro.Controls.Add(tbDescricao);
            tabPageCadastro.Controls.Add(tbDataLancamento);
            tabPageCadastro.Controls.Add(cbxDesenvolvedora);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Size = new Size(780, 348);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbNome, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxDesenvolvedora, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDataLancamento, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDescricao, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(546, 291);
            btnCancelar.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(672, 291);
            btnSalvar.TabIndex = 5;
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
            tbId.Location = new Point(24, 23);
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
            tbId.Size = new Size(150, 48);
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
            tbNome.Location = new Point(202, 23);
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
            tbNome.Size = new Size(546, 48);
            tbNome.TabIndex = 1;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // cbxDesenvolvedora
            // 
            cbxDesenvolvedora.AutoResize = false;
            cbxDesenvolvedora.BackColor = Color.FromArgb(255, 255, 255);
            cbxDesenvolvedora.Depth = 0;
            cbxDesenvolvedora.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDesenvolvedora.DropDownHeight = 174;
            cbxDesenvolvedora.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDesenvolvedora.DropDownWidth = 121;
            cbxDesenvolvedora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDesenvolvedora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDesenvolvedora.FormattingEnabled = true;
            cbxDesenvolvedora.Hint = "Desenvolvedora";
            cbxDesenvolvedora.IntegralHeight = false;
            cbxDesenvolvedora.ItemHeight = 43;
            cbxDesenvolvedora.Location = new Point(202, 91);
            cbxDesenvolvedora.MaxDropDownItems = 4;
            cbxDesenvolvedora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxDesenvolvedora.Name = "cbxDesenvolvedora";
            cbxDesenvolvedora.Size = new Size(546, 49);
            cbxDesenvolvedora.StartIndex = 0;
            cbxDesenvolvedora.TabIndex = 3;
            // 
            // tbDataLancamento
            // 
            tbDataLancamento.AllowPromptAsInput = true;
            tbDataLancamento.AnimateReadOnly = false;
            tbDataLancamento.AsciiOnly = false;
            tbDataLancamento.BackgroundImageLayout = ImageLayout.None;
            tbDataLancamento.BeepOnError = false;
            tbDataLancamento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataLancamento.Depth = 0;
            tbDataLancamento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataLancamento.HidePromptOnLeave = false;
            tbDataLancamento.HideSelection = true;
            tbDataLancamento.Hint = "Data de Lançamento";
            tbDataLancamento.InsertKeyMode = InsertKeyMode.Default;
            tbDataLancamento.LeadingIcon = null;
            tbDataLancamento.Location = new Point(24, 91);
            tbDataLancamento.Mask = "99/99/9999";
            tbDataLancamento.MaxLength = 32767;
            tbDataLancamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataLancamento.Name = "tbDataLancamento";
            tbDataLancamento.PasswordChar = '\0';
            tbDataLancamento.PrefixSuffixText = null;
            tbDataLancamento.PromptChar = '_';
            tbDataLancamento.ReadOnly = false;
            tbDataLancamento.RejectInputOnFirstFailure = false;
            tbDataLancamento.ResetOnPrompt = true;
            tbDataLancamento.ResetOnSpace = true;
            tbDataLancamento.RightToLeft = RightToLeft.No;
            tbDataLancamento.SelectedText = "";
            tbDataLancamento.SelectionLength = 0;
            tbDataLancamento.SelectionStart = 0;
            tbDataLancamento.ShortcutsEnabled = true;
            tbDataLancamento.Size = new Size(150, 48);
            tbDataLancamento.SkipLiterals = true;
            tbDataLancamento.TabIndex = 2;
            tbDataLancamento.TabStop = false;
            tbDataLancamento.Text = "  /  /";
            tbDataLancamento.TextAlign = HorizontalAlignment.Left;
            tbDataLancamento.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataLancamento.TrailingIcon = null;
            tbDataLancamento.UseSystemPasswordChar = false;
            tbDataLancamento.ValidatingType = null;
            // 
            // tbDescricao
            // 
            tbDescricao.AnimateReadOnly = false;
            tbDescricao.BackgroundImageLayout = ImageLayout.None;
            tbDescricao.CharacterCasing = CharacterCasing.Normal;
            tbDescricao.Depth = 0;
            tbDescricao.HideSelection = true;
            tbDescricao.Hint = "Descrição";
            tbDescricao.Location = new Point(24, 159);
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
            tbDescricao.Size = new Size(724, 100);
            tbDescricao.TabIndex = 4;
            tbDescricao.TabStop = false;
            tbDescricao.TextAlign = HorizontalAlignment.Left;
            tbDescricao.UseSystemPasswordChar = false;
            // 
            // CadastroJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroJogo";
            Text = "Cadastro de Jogo";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cbxDesenvolvedora;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataLancamento;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit tbDescricao;
    }
}