namespace App.Outros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnOk = new ReaLTaiizor.Controls.MaterialButton();
            bntCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tbLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            gbLogin = new GroupBox();
            tbSenha = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOk.Depth = 0;
            btnOk.HighEmphasis = true;
            btnOk.Icon = null;
            btnOk.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnOk.Location = new Point(260, 256);
            btnOk.Margin = new Padding(4, 6, 4, 6);
            btnOk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnOk.Name = "btnOk";
            btnOk.NoAccentTextColor = Color.Empty;
            btnOk.Size = new Size(64, 36);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOk.UseAccentColor = false;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bntCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bntCancelar.Depth = 0;
            bntCancelar.HighEmphasis = true;
            bntCancelar.Icon = null;
            bntCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bntCancelar.Location = new Point(89, 256);
            bntCancelar.Margin = new Padding(4, 6, 4, 6);
            bntCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bntCancelar.Name = "bntCancelar";
            bntCancelar.NoAccentTextColor = Color.Empty;
            bntCancelar.Size = new Size(96, 36);
            bntCancelar.TabIndex = 1;
            bntCancelar.Text = "Cancelar";
            bntCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bntCancelar.UseAccentColor = false;
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += bntCancelar_Click;
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
            tbLogin.Location = new Point(9, 22);
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
            tbLogin.Size = new Size(386, 48);
            tbLogin.TabIndex = 2;
            tbLogin.TabStop = false;
            tbLogin.TextAlign = HorizontalAlignment.Left;
            tbLogin.TrailingIcon = null;
            tbLogin.UseSystemPasswordChar = false;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(tbSenha);
            gbLogin.Controls.Add(tbLogin);
            gbLogin.Location = new Point(6, 67);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(406, 166);
            gbLogin.TabIndex = 4;
            gbLogin.TabStop = false;
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
            tbSenha.Location = new Point(9, 86);
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
            tbSenha.Size = new Size(386, 48);
            tbSenha.SkipLiterals = true;
            tbSenha.TabIndex = 3;
            tbSenha.TabStop = false;
            tbSenha.TextAlign = HorizontalAlignment.Left;
            tbSenha.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbSenha.TrailingIcon = null;
            tbSenha.UseSystemPasswordChar = false;
            tbSenha.ValidatingType = null;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(418, 324);
            Controls.Add(gbLogin);
            Controls.Add(bntCancelar);
            Controls.Add(btnOk);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GamesGate - Login";
            gbLogin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnOk;
        private ReaLTaiizor.Controls.MaterialButton bntCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbLogin;
        private GroupBox gbLogin;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbSenha;
    }
}