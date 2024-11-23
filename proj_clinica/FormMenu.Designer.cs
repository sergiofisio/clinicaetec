namespace proj_clinica
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip( );
            cadastroToolStripMenuItem = new ToolStripMenuItem( );
            PacienteToolStripMenuItem = new ToolStripMenuItem( );
            MedicoToolStripMenuItem = new ToolStripMenuItem( );
            MedicamentoToolStripMenuItem = new ToolStripMenuItem( );
            BtnAtendimento = new Button( );
            menuStrip1.SuspendLayout( );
            SuspendLayout( );
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(435, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PacienteToolStripMenuItem, MedicoToolStripMenuItem, MedicamentoToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(224, 36);
            cadastroToolStripMenuItem.Text = "Realizar Cadastro";
            // 
            // PacienteToolStripMenuItem
            // 
            PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem";
            PacienteToolStripMenuItem.Size = new Size(236, 36);
            PacienteToolStripMenuItem.Text = "Paciente";
            PacienteToolStripMenuItem.Click += PacienteToolStripMenuItem_Click;
            // 
            // MedicoToolStripMenuItem
            // 
            MedicoToolStripMenuItem.Name = "MedicoToolStripMenuItem";
            MedicoToolStripMenuItem.Size = new Size(236, 36);
            MedicoToolStripMenuItem.Text = "Médico";
            MedicoToolStripMenuItem.Click += MedicoToolStripMenuItem_Click;
            // 
            // MedicamentoToolStripMenuItem
            // 
            MedicamentoToolStripMenuItem.Name = "MedicamentoToolStripMenuItem";
            MedicamentoToolStripMenuItem.Size = new Size(236, 36);
            MedicamentoToolStripMenuItem.Text = "Medicamento";
            MedicamentoToolStripMenuItem.Click += MedicamentoToolStripMenuItem_Click;
            // 
            // BtnAtendimento
            // 
            BtnAtendimento.BackColor = Color.FromArgb(0, 0, 192);
            BtnAtendimento.Cursor = Cursors.Hand;
            BtnAtendimento.Dock = DockStyle.Bottom;
            BtnAtendimento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAtendimento.ForeColor = Color.White;
            BtnAtendimento.Location = new Point(0, 367);
            BtnAtendimento.Name = "BtnAtendimento";
            BtnAtendimento.Size = new Size(435, 54);
            BtnAtendimento.TabIndex = 1;
            BtnAtendimento.Text = "REALIZAR ATENDIMENTO";
            BtnAtendimento.UseVisualStyleBackColor = false;
            BtnAtendimento.Click += BtnAtendimento_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 421);
            Controls.Add(BtnAtendimento);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "FormMenu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem PacienteToolStripMenuItem;
        private ToolStripMenuItem MedicoToolStripMenuItem;
        private ToolStripMenuItem MedicamentoToolStripMenuItem;
        private Button BtnAtendimento;
    }
}
