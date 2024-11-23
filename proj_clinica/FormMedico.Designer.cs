namespace proj_clinica
{
    partial class FormMedico
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
            if(disposing && (components != null))
            {
                components.Dispose( );
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
            BtnAlterar = new Button( );
            BtnPesquisar = new Button( );
            BtnExcluir = new Button( );
            BtnIncluir = new Button( );
            TxtCrm = new TextBox( );
            TxtCpfMed = new MaskedTextBox( );
            TxtPhoneMed = new MaskedTextBox( );
            TxtNomeMed = new TextBox( );
            label5 = new Label( );
            label4 = new Label( );
            label3 = new Label( );
            label2 = new Label( );
            label1 = new Label( );
            label6 = new Label( );
            CbEspecialidade = new ComboBox( );
            DgtMedico = new DataGridView( );
            lblGrid = new Label( );
            BtnLimpar = new Button( );
            ((System.ComponentModel.ISupportInitialize)DgtMedico).BeginInit( );
            SuspendLayout( );
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackColor = Color.Green;
            BtnAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAlterar.ForeColor = Color.White;
            BtnAlterar.Location = new Point(378, 343);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(144, 54);
            BtnAlterar.TabIndex = 28;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = false;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(192, 0, 192);
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(196, 343);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(144, 54);
            BtnPesquisar.TabIndex = 27;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.Red;
            BtnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(378, 283);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(144, 54);
            BtnExcluir.TabIndex = 26;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnIncluir
            // 
            BtnIncluir.BackColor = Color.FromArgb(0, 0, 192);
            BtnIncluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncluir.ForeColor = Color.White;
            BtnIncluir.Location = new Point(196, 283);
            BtnIncluir.Name = "BtnIncluir";
            BtnIncluir.Size = new Size(144, 54);
            BtnIncluir.TabIndex = 25;
            BtnIncluir.Text = "Incluir";
            BtnIncluir.UseVisualStyleBackColor = false;
            BtnIncluir.Click += BtnIncluir_Click;
            // 
            // TxtCrm
            // 
            TxtCrm.Location = new Point(209, 60);
            TxtCrm.Name = "TxtCrm";
            TxtCrm.PlaceholderText = "Nº CRM";
            TxtCrm.Size = new Size(188, 33);
            TxtCrm.TabIndex = 24;
            TxtCrm.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtCpfMed
            // 
            TxtCpfMed.Location = new Point(209, 139);
            TxtCpfMed.Mask = "999,999,999-99";
            TxtCpfMed.Name = "TxtCpfMed";
            TxtCpfMed.Size = new Size(188, 33);
            TxtCpfMed.TabIndex = 23;
            TxtCpfMed.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtPhoneMed
            // 
            TxtPhoneMed.Location = new Point(209, 181);
            TxtPhoneMed.Mask = "(99)99999-9999";
            TxtPhoneMed.Name = "TxtPhoneMed";
            TxtPhoneMed.Size = new Size(188, 33);
            TxtPhoneMed.TabIndex = 22;
            TxtPhoneMed.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtNomeMed
            // 
            TxtNomeMed.Location = new Point(209, 100);
            TxtNomeMed.Name = "TxtNomeMed";
            TxtNomeMed.PlaceholderText = "Nome completo";
            TxtNomeMed.Size = new Size(497, 33);
            TxtNomeMed.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(110, 185);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 20;
            label5.Text = "CELULAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(157, 143);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 19;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(134, 104);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 18;
            label3.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(149, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 17;
            label2.Text = "CRM";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(718, 25);
            label1.TabIndex = 16;
            label1.Text = "CADASTRAR MÉDICO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(50, 226);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 29;
            label6.Text = "ESPECIALIDADE";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbEspecialidade
            // 
            CbEspecialidade.Cursor = Cursors.Hand;
            CbEspecialidade.FormattingEnabled = true;
            CbEspecialidade.Location = new Point(211, 222);
            CbEspecialidade.Name = "CbEspecialidade";
            CbEspecialidade.Size = new Size(495, 33);
            CbEspecialidade.Sorted = true;
            CbEspecialidade.TabIndex = 30;
            CbEspecialidade.SelectedIndexChanged += CbEspecialidade_SelectedIndexChanged;
            // 
            // DgtMedico
            // 
            DgtMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgtMedico.Location = new Point(12, 479);
            DgtMedico.Name = "DgtMedico";
            DgtMedico.Size = new Size(694, 229);
            DgtMedico.TabIndex = 31;
            DgtMedico.Visible = false;
            DgtMedico.CellClick += DgtMedico_CellClick;
            // 
            // lblGrid
            // 
            lblGrid.AutoSize = true;
            lblGrid.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrid.Location = new Point(157, 426);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new Size(383, 50);
            lblGrid.TabIndex = 35;
            lblGrid.Text = "Clique no nome do médico para editar as \r\ninformações ou excluir uma especialidade\r\n";
            lblGrid.TextAlign = ContentAlignment.MiddleCenter;
            lblGrid.Visible = false;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(566, 303);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(108, 78);
            BtnLimpar.TabIndex = 36;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // FormMedico
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 720);
            Controls.Add(BtnLimpar);
            Controls.Add(lblGrid);
            Controls.Add(DgtMedico);
            Controls.Add(CbEspecialidade);
            Controls.Add(label6);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnIncluir);
            Controls.Add(TxtCrm);
            Controls.Add(TxtCpfMed);
            Controls.Add(TxtPhoneMed);
            Controls.Add(TxtNomeMed);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormMedico";
            Text = "FormMedico";
            ((System.ComponentModel.ISupportInitialize)DgtMedico).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private Button BtnAlterar;
        private Button BtnPesquisar;
        private Button BtnExcluir;
        private Button BtnIncluir;
        private TextBox TxtCrm;
        private MaskedTextBox TxtCpfMed;
        private MaskedTextBox TxtPhoneMed;
        private TextBox TxtNomeMed;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox CbEspecialidade;
        private DataGridView DgtMedico;
        private Label lblGrid;
        private Button BtnLimpar;
    }
}