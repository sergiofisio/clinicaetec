using Estoque;
using proj_clinica.Helpers;
using System.Data;
using System.Text;

namespace proj_clinica
{
    public partial class FormAtendimento : BaseForm
    {
        private readonly ClsConexao connection;
        private readonly Functions functions;
        string medico = "";
        int cod_espec = 0;

        public FormAtendimento()
        {
            connection = new ClsConexao( );
            functions = new Functions(connection);
            InitializeComponent( );
            GetMedicos( );
            TxtCodAtendimento.Value = int.Parse(functions.GetMaxCod("tb_atendimento", "nr_atendimento", "dbclinica").ToString( ));
            DtpAtendimento.Value = DateTime.Now;
            GetAtendimentosInfo( );
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs( );

                DataSet paciente = GetPacientes(functions.CleanString(TxtCpf.Text, @"[.\-]"));

                if(paciente == null || paciente.Tables.Count == 0 || paciente.Tables[0].Rows.Count == 0)
                {
                    throw new Exception("Paciente não encontrado. Verifique o CPF informado.");
                }

                if(string.IsNullOrEmpty(medico) || cod_espec <= 0)
                {
                    throw new Exception("Selecione o médico");
                }

                string[] columns = { "nr_atendimento", "cod_paciente", "data_atendimento", "crm_medico" };
                string[] values = {
                                        TxtCodAtendimento.Text.Trim(),
                                        paciente.Tables[0].Rows[0]["cod_paciente"].ToString(),
                                        DtpAtendimento.Value.ToString("yyyy-MM-dd"), // Formato padrão para datas no SQL
                                        medico // CRM do médico selecionado
                                    };

                string resultado = functions.HandleInsert("tb_atendimento", columns, values, "dbclinica");

                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtCodAtendimento.Text = functions.GetMaxCod("tb_atendimento", "nr_atendimento", "dbclinica").ToString( );

                TxtCpf.Clear( );

                CbMedico.SelectedIndex = 0;
                GetAtendimentosInfo( );
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao incluir Atendimento:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if(CbMedico.SelectedItem.ToString( ) == "")
                {
                    return;
                }
                string[] infoMedico = CbMedico.SelectedItem.ToString( ).Split(" - ");

                DataSet ds = GetMedicoInfo(infoMedico[0], infoMedico[1]);
                medico = ds.Tables[0].Rows[0]["crm_medico"].ToString( );
                cod_espec = int.Parse(ds.Tables[0].Rows[0]["cod_espec"].ToString( ));
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar médico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataSet GetMedicoInfo(string nome, string especialidade)
        {
            try
            {
                connection.StrSql = $"SELECT * FROM tb_especialidade WHERE descricao = '{especialidade}'";
                DataSet dsEspecialidade = connection.RetornarDatase("dbclinica");
                DataTableCollection tablesEspecialidade = dsEspecialidade.Tables;
                connection.StrSql = $"SELECT * FROM tb_medico WHERE nome_medico = '{nome}' and cod_espec = {tablesEspecialidade[0].Rows[0]["cod_espec"]}";
                DataSet ds = connection.RetornarDatase("dbclinica");
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar pacientes:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataSet GetPacientes(string cpf)
        {
            try
            {
                connection.StrSql = $"SELECT * FROM tb_paciente WHERE cpf_paciente = '{cpf}'";
                DataSet ds = connection.RetornarDatase("dbclinica");
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar pacientes:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void GetMedicos()
        {
            try
            {
                string[] columns = { "crm_medico as CRM", "nome_medico as NOME", "cod_espec as ESPECIALIDADE" };
                DataTable DT = functions.HandleSearch("tb_medico", columns, "dbclinica");
                CbMedico.Items.Clear( );
                CbMedico.Items.Add("");

                if(DT.Rows.Count > 0)
                {
                    foreach(DataRow row in DT.Rows)
                    {
                        connection.StrSql = $"SELECT descricao FROM tb_especialidade WHERE cod_espec = {row["ESPECIALIDADE"]}";
                        DataSet ds = connection.RetornarDatase("dbclinica");
                        CbMedico.Items.Add($"{row["NOME"]} - {ds.Tables[0].Rows[0]["descricao"]}");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar médicos:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateInputs()
        {
            if(TxtCpf.Text.Contains("_") || string.IsNullOrEmpty(medico))
            {
                throw new Exception("Preencha todos os campos obrigatórios.");
            }
        }

        private void GetAtendimentosInfo()
        {
            try
            {
                StringBuilder querie = new( );
                querie.Append("SELECT tb_atendimento.nr_atendimento, tb_paciente.nome_paciente, ");
                querie.Append("tb_paciente.cpf_paciente, tb_medico.nome_medico, tb_medico.crm_medico ");
                querie.Append("FROM tb_atendimento ");
                querie.Append("INNER JOIN tb_paciente ON tb_atendimento.cod_paciente = tb_paciente.cod_paciente ");
                querie.Append("INNER JOIN tb_medico ON tb_atendimento.crm_medico = tb_medico.crm_medico;");

                connection.StrSql = querie.ToString( );

                DataSet ds = connection.RetornarDatase("dbclinica");

                if(ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];

                    if(dt.Rows.Count > 0)
                    {
                        DtgAtendimento.DataSource = dt;
                        DtgAtendimento.Visible = true;
                        lblGrid.Visible = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar atendimentos:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgAtendimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && DtgAtendimento.Columns[e.ColumnIndex].HeaderText == "nome_paciente")
                {
                    DataGridViewRow row = DtgAtendimento.Rows[e.RowIndex];

                    if(row.Cells["nr_atendimento"].Value != null &&
                    int.TryParse(row.Cells["nr_atendimento"].Value.ToString( ), out int codigo))
                    {
                        string nome = row.Cells["nome_paciente"].Value.ToString( );
                        FormItemAtendimento itemAtendimento = new(codigo, nome);

                        itemAtendimento.ShowDialog( );
                    }
                    else
                    {
                        MessageBox.Show("O código do atendimento é inválido ou não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar atendimentos:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            string cpf = functions.CleanString(TxtCpf.Text, @"[.\-]");
            if(cpf.Length == 11)
            {
                connection.StrSql = $"SELECT nome_paciente FROM tb_paciente WHERE cpf_paciente = '{cpf}'";
                DataSet ds = connection.RetornarDatase("dbclinica");
                lblNome.Text = ds.Tables[0].Rows[0]["nome_paciente"].ToString( );
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int CodAtendimento = int.Parse(TxtCodAtendimento.Value.ToString( ));

                if(CodAtendimento <= 0)
                {
                    throw new Exception("Selecione um atendimento antes de excluir.");
                }

                string resultado = functions.HandleDelete("tb_atendimento", "nr_atendimento", CodAtendimento.ToString( ), "dbclinica", "Atendimento");
                MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos( );
                GetAtendimentosInfo( );

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao excluir médico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            TxtCodAtendimento.Text = functions.GetMaxCod("tb_atendimento", "nr_atendimento", "dbclinica").ToString( );
            TxtCpf.Clear( );
            DtpAtendimento.Value = DateTime.Now;
            CbMedico.SelectedIndex = 0;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos( );
        }
    }
}
