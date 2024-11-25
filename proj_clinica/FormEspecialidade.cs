using Estoque;
using proj_clinica.Helpers;
using System;
using System.Data;
using System.Windows.Forms;

namespace proj_clinica
{
    public partial class FormEspecialidade : BaseForm
    {
        private readonly ClsConexao connection;
        private readonly Functions functions;
        private string descricao = "";

        public FormEspecialidade()
        {
            connection = new ClsConexao( );
            functions = new Functions(connection);
            InitializeComponent( );
            AtualizarCodigoEspecialidade( );
            txtCodEsp.Text = functions.GetMaxCod("tb_especialidade", "cod_espec", "dbclinica").ToString( );
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] columns = { "cod_espec AS CODIGO", "descricao AS DESCRICAO" };
                DataTable dt = functions.HandleSearch("tb_especialidade", columns, "dbclinica");

                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma especialidade encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DtgEspecialidades.DataSource = dt;
                DtgEspecialidades.Visible = true;
                lblGrid.Visible = true;

                DtgEspecialidades.AllowUserToAddRows = false;
                DtgEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DtgEspecialidades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DtgEspecialidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
                ValidarDescricao( );

                string[] columns = { "descricao" };
                string[] values = { descricao };

                string resultado = functions.HandleInsert("tb_especialidade", columns, values, "dbclinica");
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarCodigoEspecialidade( );

                txtDesc.Clear( );
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao incluir especialidade:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDescricao( );

                string resultado = functions.HandleDelete("tb_especialidade", "descricao", descricao, "dbclinica", "Especialidade");
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarCodigoEspecialidade( ); // Atualizar código após exclusão
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao excluir especialidade:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDescricao( );

                string[] columns = { "descricao" };
                string[] values = { descricao };

                string resultado = functions.HandleUpdate("tb_especialidade", columns, values, "descricao", descricao, "dbclinica");
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao alterar especialidade:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
        }

        private void DtgEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && DtgEspecialidades.Columns[e.ColumnIndex].HeaderText == "DESCRICAO")
                {
                    DataGridViewRow row = DtgEspecialidades.Rows[e.RowIndex];

                    txtCodEsp.Text = row.Cells["CODIGO"].Value.ToString( );
                    txtDesc.Text = row.Cells["DESCRICAO"].Value.ToString( );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar paciente:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarDescricao()
        {
            descricao = txtDesc.Text.Trim( );
            if(string.IsNullOrWhiteSpace(descricao))
            {
                throw new Exception("Informe a descrição da especialidade.");
            }
        }
        private void AtualizarCodigoEspecialidade()
        {
            try
            {
                int maxCod = functions.GetMaxCod("tb_especialidade", "cod_espec", "dbclinica");
                txtCodEsp.Text = maxCod.ToString( );
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar código da especialidade:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideGrid()
        {
            DtgEspecialidades.Visible = false;
            lblGrid.Visible = false;
        }

        private void LimparCampos()
        {
            txtCodEsp.Text = functions.GetMaxCod("tb_especialidade", "cod_espec", "dbclinica").ToString( );
            txtDesc.Clear( );
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            HideGrid( );
            LimparCampos( );
        }
    }
}
