namespace App
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            avaliaçãoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            bibliotecaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            conquistaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            desenvolvedoraToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            gêneroToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            jogoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avaliaçãoToolStripMenuItem, toolStripSeparator1, bibliotecaToolStripMenuItem, toolStripSeparator2, conquistaToolStripMenuItem, toolStripSeparator3, desenvolvedoraToolStripMenuItem, toolStripSeparator4, gêneroToolStripMenuItem, toolStripSeparator5, jogoToolStripMenuItem, toolStripSeparator6, usuárioToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // avaliaçãoToolStripMenuItem
            // 
            avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            avaliaçãoToolStripMenuItem.Size = new Size(180, 22);
            avaliaçãoToolStripMenuItem.Text = "Avaliação";
            avaliaçãoToolStripMenuItem.Click += avaliaçãoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // bibliotecaToolStripMenuItem
            // 
            bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            bibliotecaToolStripMenuItem.Size = new Size(180, 22);
            bibliotecaToolStripMenuItem.Text = "Biblioteca";
            bibliotecaToolStripMenuItem.Click += bibliotecaToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // conquistaToolStripMenuItem
            // 
            conquistaToolStripMenuItem.Name = "conquistaToolStripMenuItem";
            conquistaToolStripMenuItem.Size = new Size(180, 22);
            conquistaToolStripMenuItem.Text = "Conquista";
            conquistaToolStripMenuItem.Click += conquistaToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // desenvolvedoraToolStripMenuItem
            // 
            desenvolvedoraToolStripMenuItem.Name = "desenvolvedoraToolStripMenuItem";
            desenvolvedoraToolStripMenuItem.Size = new Size(180, 22);
            desenvolvedoraToolStripMenuItem.Text = "Desenvolvedora";
            desenvolvedoraToolStripMenuItem.Click += desenvolvedoraToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // gêneroToolStripMenuItem
            // 
            gêneroToolStripMenuItem.Name = "gêneroToolStripMenuItem";
            gêneroToolStripMenuItem.Size = new Size(180, 22);
            gêneroToolStripMenuItem.Text = "Gênero";
            gêneroToolStripMenuItem.Click += gêneroToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // jogoToolStripMenuItem
            // 
            jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            jogoToolStripMenuItem.Size = new Size(180, 22);
            jogoToolStripMenuItem.Text = "Jogo";
            jogoToolStripMenuItem.Click += jogoToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(177, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(180, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbUsuario });
            statusStrip1.Location = new Point(3, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(794, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbUsuario
            // 
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(53, 17);
            lbUsuario.Text = "Usuário: ";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbUsuario;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem avaliaçãoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem bibliotecaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem conquistaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem desenvolvedoraToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem gêneroToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem jogoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem usuárioToolStripMenuItem;
    }
}