
using Estoque;
using proj_clinica.Helpers;
using System.Data;

namespace proj_clinica
{
    public partial class FormProduto : BaseForm
    {
        private readonly ClsConexao connection;
        private readonly Functions functions;
        private string codProd, descProd, validade;
        private int qtdProd;
        private double valorProd;
        public FormProduto()
        {
            connection = new( );
            functions = new Functions(connection);
            InitializeComponent( );
            txtCodMedicamento.Text = functions.GetMaxCod("tb_prod_medic", "cod_prod", "dbclinica").ToString( );
        }

        private void DgtMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow row = DgtMedicamento.Rows[e.RowIndex];

                    txtCodMedicamento.Text = row.Cells["CODIGO"].Value?.ToString( );
                    txtMedicamento.Text = row.Cells["DESCRICAO"].Value?.ToString( );
                    txtValor.Text = row.Cells["VALOR"].Value?.ToString( );
                    DtpValidade.Text = row.Cells["VALIDADE"].Value?.ToString( );
                    txtQtdade.Text = row.Cells["QUANTIDADE"].Value?.ToString( );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs( );

                string[] columns = { "descricao_prod", "valor", "validade", "quantidade" };
                string[] values = { txtMedicamento.Text.Trim( ), txtValor.Value.ToString( ), DtpValidade.Value.ToString( ), txtQtdade.Value.ToString( ) };

                string result = functions.HandleInsert("tb_paciente", columns, values, "dbclinica");
                MessageBox.Show(result, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodMedicamento.Text = functions.GetMaxCod("tb_prod_medic", "cod_produto", "dbclinica").ToString( );
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao incluir paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtCodMedicamento.Text.Trim( )))
                {
                    throw new Exception("Preencha o código do paciente antes de excluir.");
                }

                string result = functions.HandleDelete("tb_prod_medic", "cod_prod", txtCodMedicamento.Text.Trim( ), "dbclinica", "Medicamento");
                MessageBox.Show(result, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao excluir paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] columns = { "cod_prod as CODIGO", "descricao_prod as DESCRICAO", "valor as VALOR", "validade as VALIDADE", "quantidade AS QUANTIDADE" };
                DataTable dt = functions.HandleSearch("tb_prod_medic", columns, "dbclinica");

                if(dt.Rows.Count > 0)
                {
                    DgtMedicamento.DataSource = dt;
                    DgtMedicamento.Visible = true;
                    lblGrid.Visible = true;

                    DgtMedicamento.AllowUserToAddRows = false;
                    DgtMedicamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DgtMedicamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    DgtMedicamento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs( );

                if(string.IsNullOrEmpty(txtCodMedicamento.Text.Trim( )))
                {
                    throw new Exception("Faça a pesquisa e selecione um medicamento primeiro");
                }

                string[] columns = { "valor", "validade", "quantidade" };
                string[] values = { txtValor.Value.ToString( ), DtpValidade.Value.ToString( ), txtQtdade.Value.ToString( ) };
                string result = functions.HandleUpdate("tb_paciente", columns, values, "cod_paciente", txtCodMedicamento.Text.Trim( ), "dbclinica");

                MessageBox.Show(result, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao alterar paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HideGrid( );
        }

        private void ValidateInputs()
        {
            if(string.IsNullOrEmpty(txtMedicamento.Text.Trim( )) || txtValor.Value <= 0 || txtQtdade.Value < 0)
            {
                throw new Exception("Preencha todos os campos obrigatórios.");
            }
            if(DtpValidade.Value <= DateTime.Now)
            {
                throw new Exception("A data de validade deve ser maior que a data de hoje.");
            }
        }
        private void HideGrid()
        {
            DgtMedicamento.Visible = false;
            lblGrid.Visible = false;
        }

        private void LimparCampos()
        {
            txtCodMedicamento.Text = functions.GetMaxCod("tb_prod_medic", "cod_prod", "dbclinica").ToString( );
            txtMedicamento.Clear( );
            txtQtdade.Value = 0;
            txtValor.Value = 0;
            DtpValidade.Value = DateTime.Now;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            HideGrid( );
            LimparCampos( );
        }
    }
}
