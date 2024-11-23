namespace proj_clinica
{
    partial class FormPaciente
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
            label1 = new Label( );
            label2 = new Label( );
            label3 = new Label( );
            label4 = new Label( );
            label5 = new Label( );
            txtNome = new TextBox( );
            txtPhone = new MaskedTextBox( );
            txtCpf = new MaskedTextBox( );
            txtCodPaciente = new TextBox( );
            BtnIncluir = new Button( );
            BtnExcluir = new Button( );
            BtnAlterar = new Button( );
            BtnPesquisar = new Button( );
            DtgPaciente = new DataGridView( );
            lblGrid = new Label( );
            BtnLimpar = new Button( );
            ((System.ComponentModel.ISupportInitialize)DtgPaciente).BeginInit( );
            SuspendLayout( );
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(638, 25);
            label1.TabIndex = 0;
            label1.Text = "CADASTRAR PACIENTE";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(9, 45);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 1;
            label2.Text = "CODIGO PACIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(119, 85);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "NOME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(142, 124);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 3;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(95, 166);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 4;
            label5.Text = "CELULAR";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(194, 82);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome completo";
            txtNome.Size = new Size(432, 33);
            txtNome.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(194, 163);
            txtPhone.Mask = "(99)99999-9999";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(152, 33);
            txtPhone.TabIndex = 9;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(194, 121);
            txtCpf.Mask = "999,999,999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(152, 33);
            txtCpf.TabIndex = 10;
            txtCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodPaciente
            // 
            txtCodPaciente.Location = new Point(194, 42);
            txtCodPaciente.Name = "txtCodPaciente";
            txtCodPaciente.ReadOnly = true;
            txtCodPaciente.Size = new Size(152, 33);
            txtCodPaciente.TabIndex = 11;
            txtCodPaciente.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnIncluir
            // 
            BtnIncluir.BackColor = Color.FromArgb(0, 0, 192);
            BtnIncluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncluir.ForeColor = Color.White;
            BtnIncluir.Location = new Point(165, 245);
            BtnIncluir.Name = "BtnIncluir";
            BtnIncluir.Size = new Size(144, 54);
            BtnIncluir.TabIndex = 12;
            BtnIncluir.Text = "Incluir";
            BtnIncluir.UseVisualStyleBackColor = false;
            BtnIncluir.Click += BtnIncluir_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.Red;
            BtnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(347, 245);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(144, 54);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackColor = Color.Green;
            BtnAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAlterar.ForeColor = Color.White;
            BtnAlterar.Location = new Point(347, 305);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(144, 54);
            BtnAlterar.TabIndex = 15;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = false;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(192, 0, 192);
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(165, 305);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(144, 54);
            BtnPesquisar.TabIndex = 14;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // DtgPaciente
            // 
            DtgPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgPaciente.Location = new Point(12, 450);
            DtgPaciente.Name = "DtgPaciente";
            DtgPaciente.Size = new Size(614, 189);
            DtgPaciente.TabIndex = 16;
            DtgPaciente.Visible = false;
            DtgPaciente.CellClick += DtgPaciente_CellClick;
            // 
            // lblGrid
            // 
            lblGrid.AutoSize = true;
            lblGrid.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrid.Location = new Point(130, 397);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new Size(392, 50);
            lblGrid.TabIndex = 17;
            lblGrid.Text = "Clique no nome do paciente para editar as \r\ninformações ou excluir um paciente";
            lblGrid.TextAlign = ContentAlignment.MiddleCenter;
            lblGrid.Visible = false;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(518, 267);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(108, 78);
            BtnLimpar.TabIndex = 37;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 651);
            Controls.Add(BtnLimpar);
            Controls.Add(lblGrid);
            Controls.Add(DtgPaciente);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnIncluir);
            Controls.Add(txtCodPaciente);
            Controls.Add(txtCpf);
            Controls.Add(txtPhone);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormPaciente";
            Text = "FormPaciente";
            ((System.ComponentModel.ISupportInitialize)DtgPaciente).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private MaskedTextBox txtPhone;
        private MaskedTextBox txtCpf;
        private TextBox txtCodPaciente;
        private Button BtnIncluir;
        private Button BtnExcluir;
        private Button BtnAlterar;
        private Button BtnPesquisar;
        private DataGridView DtgPaciente;
        private Label lblGrid;
        private Button BtnLimpar;
    }
}