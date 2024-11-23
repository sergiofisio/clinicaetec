namespace proj_clinica
{
    partial class FormProduto
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
            txtCodMedicamento = new TextBox( );
            label2 = new Label( );
            txtMedicamento = new TextBox( );
            label3 = new Label( );
            label4 = new Label( );
            txtValor = new NumericUpDown( );
            label5 = new Label( );
            DtpValidade = new DateTimePicker( );
            txtQtdade = new NumericUpDown( );
            label6 = new Label( );
            BtnAlterar = new Button( );
            BtnPesquisar = new Button( );
            BtnExcluir = new Button( );
            BtnIncluir = new Button( );
            lblGrid = new Label( );
            DgtMedicamento = new DataGridView( );
            BtnLimpar = new Button( );
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)txtQtdade).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)DgtMedicamento).BeginInit( );
            SuspendLayout( );
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(550, 42);
            label1.TabIndex = 1;
            label1.Text = "CADASTRAR MEDICAMENTO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCodMedicamento
            // 
            txtCodMedicamento.Location = new Point(248, 45);
            txtCodMedicamento.Name = "txtCodMedicamento";
            txtCodMedicamento.ReadOnly = true;
            txtCodMedicamento.Size = new Size(290, 33);
            txtCodMedicamento.TabIndex = 13;
            txtCodMedicamento.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(11, 48);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 12;
            label2.Text = "CODIGO MEDICAMENTO";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(248, 84);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.PlaceholderText = "Nome do Medicamento";
            txtMedicamento.Size = new Size(290, 33);
            txtMedicamento.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(126, 87);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 14;
            label3.Text = "DESCRIÇÃO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(153, 127);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 16;
            label4.Text = "VALOR $";
            // 
            // txtValor
            // 
            txtValor.DecimalPlaces = 2;
            txtValor.Location = new Point(248, 123);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(290, 33);
            txtValor.TabIndex = 17;
            txtValor.TextAlign = HorizontalAlignment.Right;
            txtValor.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(138, 167);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 18;
            label5.Text = "VALIDADE";
            // 
            // DtpValidade
            // 
            DtpValidade.Cursor = Cursors.Hand;
            DtpValidade.Format = DateTimePickerFormat.Short;
            DtpValidade.Location = new Point(248, 162);
            DtpValidade.Name = "DtpValidade";
            DtpValidade.Size = new Size(290, 33);
            DtpValidade.TabIndex = 19;
            // 
            // txtQtdade
            // 
            txtQtdade.Location = new Point(248, 202);
            txtQtdade.Name = "txtQtdade";
            txtQtdade.Size = new Size(290, 33);
            txtQtdade.TabIndex = 21;
            txtQtdade.TextAlign = HorizontalAlignment.Right;
            txtQtdade.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(106, 206);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 20;
            label6.Text = "QUANTIDADE";
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackColor = Color.Green;
            BtnAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAlterar.ForeColor = Color.White;
            BtnAlterar.Location = new Point(288, 310);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(144, 54);
            BtnAlterar.TabIndex = 25;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = false;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(192, 0, 192);
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(106, 310);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(144, 54);
            BtnPesquisar.TabIndex = 24;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.Red;
            BtnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(288, 250);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(144, 54);
            BtnExcluir.TabIndex = 23;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnIncluir
            // 
            BtnIncluir.BackColor = Color.FromArgb(0, 0, 192);
            BtnIncluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncluir.ForeColor = Color.White;
            BtnIncluir.Location = new Point(106, 250);
            BtnIncluir.Name = "BtnIncluir";
            BtnIncluir.Size = new Size(144, 54);
            BtnIncluir.TabIndex = 22;
            BtnIncluir.Text = "Incluir";
            BtnIncluir.UseVisualStyleBackColor = false;
            BtnIncluir.Click += BtnIncluir_Click;
            // 
            // lblGrid
            // 
            lblGrid.AutoSize = true;
            lblGrid.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrid.Location = new Point(138, 376);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new Size(281, 75);
            lblGrid.TabIndex = 37;
            lblGrid.Text = "Clique no medicamento\r\npara editar as informações ou \r\nexcluir um medicamento\r\n";
            lblGrid.TextAlign = ContentAlignment.MiddleCenter;
            lblGrid.Visible = false;
            // 
            // DgtMedicamento
            // 
            DgtMedicamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgtMedicamento.Location = new Point(11, 465);
            DgtMedicamento.Name = "DgtMedicamento";
            DgtMedicamento.Size = new Size(526, 229);
            DgtMedicamento.TabIndex = 36;
            DgtMedicamento.Visible = false;
            DgtMedicamento.CellContentClick += DgtMedicamento_CellContentClick;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(441, 278);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(97, 67);
            BtnLimpar.TabIndex = 38;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 706);
            Controls.Add(BtnLimpar);
            Controls.Add(lblGrid);
            Controls.Add(DgtMedicamento);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnIncluir);
            Controls.Add(txtQtdade);
            Controls.Add(label6);
            Controls.Add(DtpValidade);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(txtMedicamento);
            Controls.Add(label3);
            Controls.Add(txtCodMedicamento);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormProduto";
            Text = "FormProduto";
            ((System.ComponentModel.ISupportInitialize)txtValor).EndInit( );
            ((System.ComponentModel.ISupportInitialize)txtQtdade).EndInit( );
            ((System.ComponentModel.ISupportInitialize)DgtMedicamento).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private Label label1;
        private TextBox txtCodMedicamento;
        private Label label2;
        private TextBox txtMedicamento;
        private Label label3;
        private Label label4;
        private NumericUpDown txtValor;
        private Label label5;
        private DateTimePicker DtpValidade;
        private NumericUpDown txtQtdade;
        private Label label6;
        private Button BtnAlterar;
        private Button BtnPesquisar;
        private Button BtnExcluir;
        private Button BtnIncluir;
        private Label lblGrid;
        private DataGridView DgtMedicamento;
        private Button BtnLimpar;
    }
}