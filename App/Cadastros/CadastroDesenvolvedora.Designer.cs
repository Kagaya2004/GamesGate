namespace App.Cadastros
{
    partial class CadastroDesenvolvedora
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
            tbEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbPais = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbSite = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbDescricao = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Size = new Size(731, 390);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbDescricao);
            tabPageCadastro.Controls.Add(tbSite);
            tabPageCadastro.Controls.Add(tbEmail);
            tabPageCadastro.Controls.Add(tbPais);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Size = new Size(723, 355);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(tbNome, 0);
            tabPageCadastro.Controls.SetChildIndex(tbPais, 0);
            tabPageCadastro.Controls.SetChildIndex(tbEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(tbSite, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDescricao, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(500, 298);
            btnCancelar.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(623, 298);
            btnSalvar.TabIndex = 6;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(446, 300);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(536, 300);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(626, 300);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(723, 355);
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
            tbEmail.Location = new Point(366, 84);
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
            tbEmail.Size = new Size(333, 48);
            tbEmail.TabIndex = 4;
            tbEmail.TabStop = false;
            tbEmail.TextAlign = HorizontalAlignment.Left;
            tbEmail.TrailingIcon = null;
            tbEmail.UseSystemPasswordChar = false;
            // 
            // tbPais
            // 
            tbPais.AnimateReadOnly = false;
            tbPais.AutoCompleteMode = AutoCompleteMode.None;
            tbPais.AutoCompleteSource = AutoCompleteSource.None;
            tbPais.BackgroundImageLayout = ImageLayout.None;
            tbPais.CharacterCasing = CharacterCasing.Normal;
            tbPais.Depth = 0;
            tbPais.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPais.HideSelection = true;
            tbPais.Hint = "País";
            tbPais.LeadingIcon = null;
            tbPais.Location = new Point(132, 16);
            tbPais.MaxLength = 32767;
            tbPais.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPais.Name = "tbPais";
            tbPais.PasswordChar = '\0';
            tbPais.PrefixSuffixText = null;
            tbPais.ReadOnly = false;
            tbPais.RightToLeft = RightToLeft.No;
            tbPais.SelectedText = "";
            tbPais.SelectionLength = 0;
            tbPais.SelectionStart = 0;
            tbPais.ShortcutsEnabled = true;
            tbPais.Size = new Size(261, 48);
            tbPais.TabIndex = 1;
            tbPais.TabStop = false;
            tbPais.TextAlign = HorizontalAlignment.Left;
            tbPais.TrailingIcon = null;
            tbPais.UseSystemPasswordChar = false;
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
            tbNome.Location = new Point(23, 84);
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
            tbNome.Size = new Size(317, 48);
            tbNome.TabIndex = 3;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
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
            tbId.Location = new Point(23, 16);
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
            // tbSite
            // 
            tbSite.AnimateReadOnly = false;
            tbSite.AutoCompleteMode = AutoCompleteMode.None;
            tbSite.AutoCompleteSource = AutoCompleteSource.None;
            tbSite.BackgroundImageLayout = ImageLayout.None;
            tbSite.CharacterCasing = CharacterCasing.Normal;
            tbSite.Depth = 0;
            tbSite.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSite.HideSelection = true;
            tbSite.Hint = "Site";
            tbSite.LeadingIcon = null;
            tbSite.Location = new Point(414, 16);
            tbSite.MaxLength = 32767;
            tbSite.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSite.Name = "tbSite";
            tbSite.PasswordChar = '\0';
            tbSite.PrefixSuffixText = null;
            tbSite.ReadOnly = false;
            tbSite.RightToLeft = RightToLeft.No;
            tbSite.SelectedText = "";
            tbSite.SelectionLength = 0;
            tbSite.SelectionStart = 0;
            tbSite.ShortcutsEnabled = true;
            tbSite.Size = new Size(284, 48);
            tbSite.TabIndex = 2;
            tbSite.TabStop = false;
            tbSite.TextAlign = HorizontalAlignment.Left;
            tbSite.TrailingIcon = null;
            tbSite.UseSystemPasswordChar = false;
            // 
            // tbDescricao
            // 
            tbDescricao.AnimateReadOnly = false;
            tbDescricao.BackgroundImageLayout = ImageLayout.None;
            tbDescricao.CharacterCasing = CharacterCasing.Normal;
            tbDescricao.Depth = 0;
            tbDescricao.HideSelection = true;
            tbDescricao.Hint = "Descrição";
            tbDescricao.Location = new Point(23, 152);
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
            tbDescricao.Size = new Size(675, 125);
            tbDescricao.TabIndex = 5;
            tbDescricao.TabStop = false;
            tbDescricao.TextAlign = HorizontalAlignment.Left;
            tbDescricao.UseSystemPasswordChar = false;
            // 
            // CadastroDesenvolvedora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 463);
            Location = new Point(0, 0);
            Name = "CadastroDesenvolvedora";
            Text = "Cadastro de Desenvolvedora";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPais;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSite;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit tbDescricao;
    }
}