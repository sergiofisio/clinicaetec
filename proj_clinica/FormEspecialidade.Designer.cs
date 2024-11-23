namespace proj_clinica
{
    partial class FormEspecialidade
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
            txtDesc = new TextBox( );
            label3 = new Label( );
            label2 = new Label( );
            txtCodEsp = new TextBox( );
            BtnAlterar = new Button( );
            BtnPesquisar = new Button( );
            BtnExcluir = new Button( );
            BtnIncluir = new Button( );
            DtgEspecialidades = new DataGridView( );
            lblGrid = new Label( );
            BtnLimpar = new Button( );
            ((System.ComponentModel.ISupportInitialize)DtgEspecialidades).BeginInit( );
            SuspendLayout( );
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(551, 42);
            label1.TabIndex = 17;
            label1.Text = "CADASTRAR ESPECIALIDADE";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(256, 123);
            txtDesc.Margin = new Padding(5);
            txtDesc.MaxLength = 30;
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Descrição";
            txtDesc.Size = new Size(280, 33);
            txtDesc.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(130, 127);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 26;
            label3.Text = "DESCRIÇÃO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(14, 83);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 25;
            label2.Text = "CÓDIGO ESPECIALIDADE";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCodEsp
            // 
            txtCodEsp.Location = new Point(256, 80);
            txtCodEsp.Margin = new Padding(5);
            txtCodEsp.Name = "txtCodEsp";
            txtCodEsp.ReadOnly = true;
            txtCodEsp.Size = new Size(280, 33);
            txtCodEsp.TabIndex = 28;
            txtCodEsp.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackColor = Color.Green;
            BtnAlterar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAlterar.ForeColor = Color.White;
            BtnAlterar.Location = new Point(296, 248);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(144, 54);
            BtnAlterar.TabIndex = 32;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = false;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(192, 0, 192);
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(114, 248);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(144, 54);
            BtnPesquisar.TabIndex = 31;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.Red;
            BtnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(296, 188);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(144, 54);
            BtnExcluir.TabIndex = 30;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnIncluir
            // 
            BtnIncluir.BackColor = Color.FromArgb(0, 0, 192);
            BtnIncluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncluir.ForeColor = Color.White;
            BtnIncluir.Location = new Point(114, 188);
            BtnIncluir.Name = "BtnIncluir";
            BtnIncluir.Size = new Size(144, 54);
            BtnIncluir.TabIndex = 29;
            BtnIncluir.Text = "Incluir";
            BtnIncluir.UseVisualStyleBackColor = false;
            BtnIncluir.Click += BtnIncluir_Click;
            // 
            // DtgEspecialidades
            // 
            DtgEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgEspecialidades.Location = new Point(14, 409);
            DtgEspecialidades.Name = "DtgEspecialidades";
            DtgEspecialidades.Size = new Size(522, 230);
            DtgEspecialidades.TabIndex = 33;
            DtgEspecialidades.Visible = false;
            DtgEspecialidades.CellClick += DtgEspecialidades_CellContentClick;
            // 
            // lblGrid
            // 
            lblGrid.AutoSize = true;
            lblGrid.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrid.Location = new Point(140, 331);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new Size(281, 75);
            lblGrid.TabIndex = 34;
            lblGrid.Text = "Clique na especialidade\r\npara editar as informações ou \r\nexcluir uma especialidade\r\n";
            lblGrid.TextAlign = ContentAlignment.MiddleCenter;
            lblGrid.Visible = false;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(454, 211);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(85, 60);
            BtnLimpar.TabIndex = 38;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // FormEspecialidade
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 651);
            Controls.Add(BtnLimpar);
            Controls.Add(lblGrid);
            Controls.Add(DtgEspecialidades);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnIncluir);
            Controls.Add(txtCodEsp);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormEspecialidade";
            Text = "FormEspecialidade";
            ((System.ComponentModel.ISupportInitialize)DtgEspecialidades).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private Label label1;
        private TextBox txtDesc;
        private Label label3;
        private Label label2;
        private TextBox txtCodEsp;
        private Button BtnAlterar;
        private Button BtnPesquisar;
        private Button BtnExcluir;
        private Button BtnIncluir;
        private DataGridView DtgEspecialidades;
        private Label lblGrid;
        private Button BtnLimpar;
    }
}