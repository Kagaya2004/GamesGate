namespace App.Cadastros
{
    partial class CadastroConquista
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
            cbxJogo = new ReaLTaiizor.Controls.MaterialComboBox();
            tbDescricao = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbDescricao);
            tabPageCadastro.Controls.Add(cbxJogo);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxJogo, 0);
            tabPageCadastro.Controls.SetChildIndex(tbDescricao, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.TabIndex = 3;
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
            tbId.Location = new Point(24, 27);
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
            tbId.Size = new Size(250, 48);
            tbId.TabIndex = 0;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
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
            cbxJogo.Location = new Point(313, 26);
            cbxJogo.MaxDropDownItems = 4;
            cbxJogo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxJogo.Name = "cbxJogo";
            cbxJogo.Size = new Size(402, 49);
            cbxJogo.StartIndex = 0;
            cbxJogo.TabIndex = 1;
            // 
            // tbDescricao
            // 
            tbDescricao.AnimateReadOnly = false;
            tbDescricao.BackgroundImageLayout = ImageLayout.None;
            tbDescricao.CharacterCasing = CharacterCasing.Normal;
            tbDescricao.Depth = 0;
            tbDescricao.HideSelection = true;
            tbDescricao.Hint = "Descrição";
            tbDescricao.Location = new Point(24, 93);
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
            tbDescricao.Size = new Size(691, 176);
            tbDescricao.TabIndex = 2;
            tbDescricao.TabStop = false;
            tbDescricao.TextAlign = HorizontalAlignment.Left;
            tbDescricao.UseSystemPasswordChar = false;
            // 
            // CadastroConquista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Location = new Point(0, 0);
            Name = "CadastroConquista";
            Text = "Cadastro de Conquista";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cbxJogo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit tbDescricao;
    }
}