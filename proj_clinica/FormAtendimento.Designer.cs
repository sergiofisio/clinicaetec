namespace proj_clinica
{
    partial class FormAtendimento
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
            BtnExcluir = new Button( );
            BtnIncluir = new Button( );
            label3 = new Label( );
            label2 = new Label( );
            label1 = new Label( );
            TxtCpf = new MaskedTextBox( );
            lblNome = new Label( );
            label4 = new Label( );
            DtpAtendimento = new DateTimePicker( );
            label5 = new Label( );
            CbMedico = new ComboBox( );
            DtgAtendimento = new DataGridView( );
            lblGrid = new Label( );
            BtnLimpar = new Button( );
            TxtCodAtendimento = new NumericUpDown( );
            ((System.ComponentModel.ISupportInitialize)DtgAtendimento).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)TxtCodAtendimento).BeginInit( );
            SuspendLayout( );
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.Red;
            BtnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(339, 233);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(144, 54);
            BtnExcluir.TabIndex = 38;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnIncluir
            // 
            BtnIncluir.BackColor = Color.FromArgb(0, 0, 192);
            BtnIncluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncluir.ForeColor = Color.White;
            BtnIncluir.Location = new Point(157, 233);
            BtnIncluir.Name = "BtnIncluir";
            BtnIncluir.Size = new Size(144, 54);
            BtnIncluir.TabIndex = 37;
            BtnIncluir.Text = "Incluir";
            BtnIncluir.UseVisualStyleBackColor = false;
            BtnIncluir.Click += BtnIncluir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(104, 110);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 29;
            label3.Text = "CPF PACIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(8, 69);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 27;
            label2.Text = "NÚMERO ATENDIMENTO";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(674, 42);
            label1.TabIndex = 26;
            label1.Text = "CADASTRAR ATENDIMENTO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(249, 105);
            TxtCpf.Mask = "999,999,999-99";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(165, 33);
            TxtCpf.TabIndex = 39;
            TxtCpf.TextAlign = HorizontalAlignment.Center;
            TxtCpf.TextChanged += TxtCpf_TextChanged;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(415, 105);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(247, 30);
            lblNome.TabIndex = 40;
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(42, 148);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 41;
            label4.Text = "DATA ATENDIMENTO";
            // 
            // DtpAtendimento
            // 
            DtpAtendimento.Cursor = Cursors.Hand;
            DtpAtendimento.Enabled = false;
            DtpAtendimento.Format = DateTimePickerFormat.Short;
            DtpAtendimento.Location = new Point(249, 144);
            DtpAtendimento.Name = "DtpAtendimento";
            DtpAtendimento.Size = new Size(304, 33);
            DtpAtendimento.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(157, 187);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 43;
            label5.Text = "MÉDICO";
            // 
            // CbMedico
            // 
            CbMedico.FormattingEnabled = true;
            CbMedico.Location = new Point(249, 183);
            CbMedico.Name = "CbMedico";
            CbMedico.Size = new Size(304, 33);
            CbMedico.TabIndex = 44;
            CbMedico.SelectedIndexChanged += CbMedico_SelectedIndexChanged;
            // 
            // DtgAtendimento
            // 
            DtgAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgAtendimento.Location = new Point(8, 339);
            DtgAtendimento.Name = "DtgAtendimento";
            DtgAtendimento.Size = new Size(654, 229);
            DtgAtendimento.TabIndex = 45;
            DtgAtendimento.Visible = false;
            DtgAtendimento.CellContentClick += DtgAtendimento_CellContentClick;
            // 
            // lblGrid
            // 
            lblGrid.AutoSize = true;
            lblGrid.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrid.Location = new Point(53, 311);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new Size(550, 25);
            lblGrid.TabIndex = 46;
            lblGrid.Text = "CLIQUE NO NOME DO PACIENTE PARA INICIAR A CONSULTA";
            lblGrid.Visible = false;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(554, 233);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(108, 54);
            BtnLimpar.TabIndex = 47;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // TxtCodAtendimento
            // 
            TxtCodAtendimento.Location = new Point(249, 66);
            TxtCodAtendimento.Name = "TxtCodAtendimento";
            TxtCodAtendimento.Size = new Size(304, 33);
            TxtCodAtendimento.TabIndex = 48;
            TxtCodAtendimento.TextAlign = HorizontalAlignment.Center;
            // 
            // FormAtendimento
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 580);
            Controls.Add(TxtCodAtendimento);
            Controls.Add(BtnLimpar);
            Controls.Add(lblGrid);
            Controls.Add(DtgAtendimento);
            Controls.Add(CbMedico);
            Controls.Add(label5);
            Controls.Add(DtpAtendimento);
            Controls.Add(label4);
            Controls.Add(lblNome);
            Controls.Add(TxtCpf);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnIncluir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormAtendimento";
            Text = "FormAtendimento";
            ((System.ComponentModel.ISupportInitialize)DtgAtendimento).EndInit( );
            ((System.ComponentModel.ISupportInitialize)TxtCodAtendimento).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion
        private Button BtnExcluir;
        private Button BtnIncluir;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox TxtCpf;
        private Label lblNome;
        private Label label4;
        private DateTimePicker DtpAtendimento;
        private Label label5;
        private ComboBox CbMedico;
        private DataGridView DtgAtendimento;
        private Label lblGrid;
        private Button BtnLimpar;
        private NumericUpDown TxtCodAtendimento;
    }
}