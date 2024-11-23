using Estoque;
using proj_clinica.Helpers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace proj_clinica
{
    public partial class FormMedico : BaseForm
    {
        private readonly ClsConexao connection;
        private readonly Functions functions;
        private string crm, nome, cpf, celular, codEsp;

        public FormMedico()
        {
            connection = new ClsConexao( );
            functions = new Functions(connection);
            InitializeComponent( );
            PreencherEspecialidades( );

            DgtMedico.CellClick += DgtMedico_CellClick;
        }

        private void CbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = CbEspecialidade.SelectedItem.ToString( );
                if(selected == "Adicionar Novo")
                {
                    using FormEspecialidade formEspecialidade = new( );
                    formEspecialidade.ShowDialog( );
                    PreencherEspecialidades( );
                }
                else
                {
                    if(selected != "")
                    {
                        string[] columns = { "cod_espec", "descricao" };
                        string where = $"descricao = '{selected}'";

                        connection.StrSql = $"SELECT cod_espec FROM tb_especialidade WHERE {where}";
                        DataSet ds = connection.RetornarDatase("dbclinica");

                        if(ds.Tables[0].Rows.Count > 0)
                        {
                            codEsp = ds.Tables[0].Rows[0]["cod_espec"].ToString( );
                        }
                        else
                        {
                            codEsp = string.Empty;
                            throw new Exception("Especialidade selecionada não encontrada.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar especialidade:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] columns = {
                                    "crm_medico AS CRM",
                                    "nome_medico AS NOME",
                                    "cpf_medico AS CPF",
                                    "celular_medico AS CELULAR",
                                    "cod_espec AS CODIGO_ESPECIALIDADE"
                                };
                DataTable dt = functions.HandleSearch("tb_medico", columns, "dbclinica");

                if(dt.Rows.Count == 0)
                {
                    throw new Exception("Nenhum médico encontrado.");
                }

                DgtMedico.DataSource = dt;
                DgtMedico.Visible = true;
                lblGrid.Visible = true;

                DgtMedico.AllowUserToAddRows = false;

                DgtMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgtMedico.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgtMedico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar médico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos( );

                string[] columns = { "crm_medico", "nome_medico", "cpf_medico", "celular_medico", "cod_espec" };
                string[] values = { crm, nome, cpf, celular, codEsp };

                string resultado = functions.HandleInsert("tb_medico", columns, values, "dbclinica");
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos( );
            }
            catch(Exception ex)
            {
                if(ex.InnerException.Message.Contains("UNIQUE"))
                {
                    if(ex.Message.Contains("cpf_medico"))
                    {
                        MessageBox.Show("CPF já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(ex.Message.Contains("crm_medico"))
                    {
                        MessageBox.Show("CRM já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Erro ao incluir médico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            HideGrid( );
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCrm( );

                string resultado = functions.HandleDelete("tb_medico", "crm_medico", crm, "dbclinica", "Médico");
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos( );

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao excluir médico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos( );

                string[] columns = { "celular_medico", "cod_espec" };
                string[] values = { celular, codEsp };

                string resultado = functions.HandleUpdate("tb_medico", columns, values, "crm_medico", crm, "dbclinica");
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao alterar médico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideGrid( );
            LimparCampos( );
        }

        private void DgtMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && e.RowIndex < DgtMedico.Rows.Count - (DgtMedico.AllowUserToAddRows ? 1 : 0))
                {
                    DataGridViewRow row = DgtMedico.Rows[e.RowIndex];

                    TxtCrm.Text = row.Cells["CRM"].Value?.ToString( ) ?? string.Empty;
                    TxtNomeMed.Text = row.Cells["NOME"].Value?.ToString( ) ?? string.Empty;
                    TxtCpfMed.Text = row.Cells["CPF"].Value?.ToString( ) ?? string.Empty;
                    TxtPhoneMed.Text = row.Cells["CELULAR"].Value?.ToString( ) ?? string.Empty;

                    string codEspecialidade = row.Cells["CODIGO_ESPECIALIDADE"].Value?.ToString( );

                    if(!string.IsNullOrEmpty(codEspecialidade))
                    {
                        connection.StrSql = $"SELECT descricao FROM tb_especialidade WHERE cod_espec = {codEspecialidade}";
                        DataSet ds = connection.RetornarDatase("dbclinica");

                        if(ds.Tables[0].Rows.Count > 0)
                        {
                            string descricao = ds.Tables[0].Rows[0]["descricao"].ToString( );

                            int index = CbEspecialidade.FindStringExact(descricao);
                            if(index >= 0)
                            {
                                CbEspecialidade.SelectedIndex = index;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar médico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarCampos()
        {
            crm = TxtCrm.Text.Trim( );
            nome = TxtNomeMed.Text.Trim( );
            cpf = functions.CleanString(TxtCpfMed.Text, @"[.\-]");
            celular = functions.CleanString(TxtPhoneMed.Text, @"[()\-\s]");

            if(string.IsNullOrEmpty(crm) || string.IsNullOrEmpty(nome) || cpf.Contains("_") || celular.Contains("_") || string.IsNullOrEmpty(codEsp))
            {
                throw new Exception("Preencha todos os campos obrigatórios.");
            }
        }

        private void ValidarCrm()
        {
            crm = TxtCrm.Text.Trim( );
            if(string.IsNullOrEmpty(crm))
            {
                throw new Exception("Informe o CRM do médico.");
            }
        }

        private void LimparCampos()
        {
            TxtCrm.Clear( );
            TxtNomeMed.Clear( );
            TxtCpfMed.Clear( );
            TxtPhoneMed.Clear( );
            CbEspecialidade.SelectedIndex = 0;
        }

        private void HideGrid()
        {
            DgtMedico.Visible = false;
            lblGrid.Visible = false;
        }

        private void PreencherEspecialidades()
        {
            try
            {
                string[] columns = { "descricao" };
                DataTable dt = functions.HandleSearch("tb_especialidade", columns, "dbclinica");

                CbEspecialidade.Items.Clear( );

                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        CbEspecialidade.Items.Add(row["descricao"]);
                    }
                }
                CbEspecialidade.Items.Add("");
                CbEspecialidade.Items.Add("Adicionar Novo");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar especialidades:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos( );
            HideGrid( );
        }
    }
}
