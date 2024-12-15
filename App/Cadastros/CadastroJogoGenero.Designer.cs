namespace App.Cadastros
{
    partial class CadastroJogoGenero
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
            cbxGenero = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Size = new Size(777, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cbxGenero);
            tabPageCadastro.Controls.Add(cbxJogo);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Size = new Size(769, 348);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(tbId, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxJogo, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxGenero, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(535, 291);
            btnCancelar.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(661, 291);
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
            tbId.Location = new Point(18, 31);
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
            tbId.Size = new Size(105, 48);
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
            cbxJogo.Location = new Point(147, 32);
            cbxJogo.MaxDropDownItems = 4;
            cbxJogo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxJogo.Name = "cbxJogo";
            cbxJogo.Size = new Size(283, 49);
            cbxJogo.StartIndex = 0;
            cbxJogo.TabIndex = 1;
            // 
            // cbxGenero
            // 
            cbxGenero.AutoResize = false;
            cbxGenero.BackColor = Color.FromArgb(255, 255, 255);
            cbxGenero.Depth = 0;
            cbxGenero.DrawMode = DrawMode.OwnerDrawVariable;
            cbxGenero.DropDownHeight = 174;
            cbxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGenero.DropDownWidth = 121;
            cbxGenero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxGenero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Hint = "Gênero";
            cbxGenero.IntegralHeight = false;
            cbxGenero.ItemHeight = 43;
            cbxGenero.Location = new Point(454, 32);
            cbxGenero.MaxDropDownItems = 4;
            cbxGenero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(283, 49);
            cbxGenero.StartIndex = 0;
            cbxGenero.TabIndex = 2;
            // 
            // CadastroJogoGenero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroJogoGenero";
            Text = "Cadastro de JogoGênero";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cbxGenero;
        private ReaLTaiizor.Controls.MaterialComboBox cbxJogo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
    }
}