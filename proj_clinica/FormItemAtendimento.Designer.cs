namespace proj_clinica
{
    partial class FormItemAtendimento
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
            groupBox1 = new GroupBox( );
            lblNome = new Label( );
            BoxPrescrição = new ListBox( );
            label2 = new Label( );
            label3 = new Label( );
            CbMedicamento = new ComboBox( );
            label4 = new Label( );
            TxtQtdade = new NumericUpDown( );
            btnIncluir = new Button( );
            BtnSalvar = new Button( );
            groupBox1.SuspendLayout( );
            ((System.ComponentModel.ISupportInitialize)TxtQtdade).BeginInit( );
            SuspendLayout( );
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome Paciente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 48);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(163, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 25);
            lblNome.TabIndex = 1;
            // 
            // BoxPrescrição
            // 
            BoxPrescrição.FormattingEnabled = true;
            BoxPrescrição.ItemHeight = 25;
            BoxPrescrição.Location = new Point(6, 85);
            BoxPrescrição.Name = "BoxPrescrição";
            BoxPrescrição.Size = new Size(469, 154);
            BoxPrescrição.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 3;
            label2.Text = "Prescrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 251);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 4;
            label3.Text = "Medicamento";
            // 
            // CbMedicamento
            // 
            CbMedicamento.FormattingEnabled = true;
            CbMedicamento.Location = new Point(6, 279);
            CbMedicamento.Name = "CbMedicamento";
            CbMedicamento.Size = new Size(247, 33);
            CbMedicamento.TabIndex = 5;
            CbMedicamento.SelectedIndexChanged += CbMedicamento_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 251);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // TxtQtdade
            // 
            TxtQtdade.Location = new Point(262, 280);
            TxtQtdade.Name = "TxtQtdade";
            TxtQtdade.Size = new Size(120, 33);
            TxtQtdade.TabIndex = 7;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(388, 279);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(87, 33);
            btnIncluir.TabIndex = 8;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += BtnIncluir_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Blue;
            BtnSalvar.Dock = DockStyle.Bottom;
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(0, 335);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(487, 42);
            BtnSalvar.TabIndex = 9;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // FormItemAtendimento
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 377);
            Controls.Add(BtnSalvar);
            Controls.Add(btnIncluir);
            Controls.Add(TxtQtdade);
            Controls.Add(label4);
            Controls.Add(CbMedicamento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BoxPrescrição);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormItemAtendimento";
            Text = "FormItemAtendimento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout( );
            ((System.ComponentModel.ISupportInitialize)TxtQtdade).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lblNome;
        private ListBox BoxPrescrição;
        private Label label2;
        private Label label3;
        private ComboBox CbMedicamento;
        private Label label4;
        private NumericUpDown TxtQtdade;
        private Button btnIncluir;
        private Button BtnSalvar;
    }
}