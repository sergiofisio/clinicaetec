using Estoque;
using proj_clinica.Helpers;
using System.Data;

namespace proj_clinica
{
    public partial class FormPaciente : BaseForm
    {
        private readonly ClsConexao connection;
        private readonly Functions functions;
        private string codPcte, nome, cpf, celular;

        public FormPaciente()
        {
            connection = new ClsConexao( );
            functions = new Functions(connection);
            InitializeComponent( );
            txtCodPaciente.Text = functions.GetMaxCod("tb_paciente", "cod_paciente", "dbclinica").ToString( );
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] columns = { "cod_paciente as CODIGO", "nome_paciente as NOME", "cpf_paciente as CPF", "celular_paciente as CELULAR" };
                DataTable dt = functions.HandleSearch("tb_paciente", columns, "dbclinica");

                if(dt.Rows.Count > 0)
                {
                    DtgPaciente.DataSource = dt;
                    DtgPaciente.Visible = true;
                    lblGrid.Visible = true;

                    DtgPaciente.AllowUserToAddRows = false;
                    DtgPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DtgPaciente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    DtgPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                }
                else
                {
                    MessageBox.Show("Nenhum paciente encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs( );

                string[] columns = { "nome_paciente", "cpf_paciente", "celular_paciente" };
                string[] values = { nome, cpf, celular };

                string result = functions.HandleInsert("tb_paciente", columns, values, "dbclinica");
                MessageBox.Show(result, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodPaciente.Text = functions.GetMaxCod("tb_paciente", "cod_paciente", "dbclinica").ToString( );
                LimparCampos( );
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("CPF já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Erro ao incluir paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            HideGrid( );
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                codPcte = txtCodPaciente.Text.Trim( );

                string result = functions.HandleDelete("tb_paciente", "cod_paciente", codPcte, "dbclinica", "Paciente");
                MessageBox.Show(result, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos( );
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao excluir paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs( );
                codPcte = txtCodPaciente.Text.Trim( );

                string[] columns = { "nome_paciente", "cpf_paciente", "celular_paciente" };
                string[] values = { nome, cpf, celular };
                string result = functions.HandleUpdate("tb_paciente", columns, values, "cod_paciente", codPcte, "dbclinica");

                MessageBox.Show(result, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos( );
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao alterar paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
        }
        private void DtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && DtgPaciente.Columns[e.ColumnIndex].HeaderText == "NOME")
                {
                    DataGridViewRow row = DtgPaciente.Rows[e.RowIndex];

                    txtCodPaciente.Text = row.Cells["CODIGO"].Value?.ToString( );
                    txtNome.Text = row.Cells["NOME"].Value?.ToString( );
                    txtCpf.Text = row.Cells["CPF"].Value?.ToString( );
                    txtPhone.Text = row.Cells["CELULAR"].Value?.ToString( );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateInputs()
        {
            nome = txtNome.Text.Trim( );
            cpf = functions.CleanString(txtCpf.Text, @"[.\-]");
            celular = functions.CleanString(txtPhone.Text, @"[()\-\s]");
            MessageBox.Show($"{cpf} {cpf.Length} {celular} {celular.Length}");

            if(string.IsNullOrEmpty(nome))
            {
                throw new Exception("O campo 'Nome' é obrigatório.");
            }

            if(cpf.Length != 11 || cpf.Contains("_"))
            {
                throw new Exception("O CPF está incompleto ou inválido.");
            }

            if(celular.Length != 11 || celular.Contains("_"))
            {
                throw new Exception("O número de celular está incompleto ou inválido.");
            }
        }

        private void HideGrid()
        {
            DtgPaciente.Visible = false;
            lblGrid.Visible = false;
        }

        private void LimparCampos()
        {
            txtCodPaciente.Text = functions.GetMaxCod("tb_paciente", "cod_paciente", "dbclinica").ToString( );
            txtCpf.Clear( );
            txtNome.Clear( );
            txtPhone.Clear( );
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos( );
            HideGrid( );
        }
    }
}
