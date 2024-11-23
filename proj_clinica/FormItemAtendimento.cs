using Estoque;
using proj_clinica.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_clinica
{
    public partial class FormItemAtendimento : BaseForm
    {
        private readonly ClsConexao connection;
        private readonly Functions functions;
        public int CodigoAtendimento { get; private set; }
        public string nomePaciente { get; private set; }

        string medicamento;
        int quantidade;

        public FormItemAtendimento(int codigoAtendimento, string nome)
        {
            connection = new ClsConexao( );
            functions = new Functions(connection);
            InitializeComponent( );
            CodigoAtendimento = codigoAtendimento;
            nomePaciente = nome;
            lblNome.Text = nomePaciente;
            getInfoAtendimento( );
            GetMedicamentos( );
        }

        private void getInfoAtendimento()
        {
            try
            {
                StringBuilder queryItensAtendimento = new( );
                queryItensAtendimento.Append("SELECT cod_prod, SUM(quantidade) as quantidade ");
                queryItensAtendimento.Append("FROM tb_itens_atendimento ");
                queryItensAtendimento.Append($"WHERE nr_atendimento = {CodigoAtendimento} ");
                queryItensAtendimento.Append("GROUP BY cod_prod;");

                connection.StrSql = queryItensAtendimento.ToString( );
                DataSet dsItens = connection.RetornarDatase("dbclinica");

                BoxPrescrição.Items.Clear( );

                if(dsItens.Tables.Count > 0 && dsItens.Tables[0].Rows.Count > 0)
                {
                    DataTable dtItens = dsItens.Tables[0];

                    foreach(DataRow itemRow in dtItens.Rows)
                    {
                        try
                        {
                            int codProd = Convert.ToInt32(itemRow["cod_prod"]);
                            int quantidade = Convert.ToInt32(itemRow["quantidade"]);

                            StringBuilder queryProduto = new( );
                            queryProduto.Append("SELECT descricao_prod, valor ");
                            queryProduto.Append("FROM tb_prod_medic ");
                            queryProduto.Append($"WHERE cod_prod = {codProd};");

                            connection.StrSql = queryProduto.ToString( );
                            DataSet dsProduto = connection.RetornarDatase("dbclinica");

                            if(dsProduto.Tables.Count > 0 && dsProduto.Tables[0].Rows.Count > 0)
                            {
                                DataTable dtProduto = dsProduto.Tables[0];
                                DataRow produtoRow = dtProduto.Rows[0];
                                string descricaoProd = produtoRow["descricao_prod"].ToString( );
                                decimal valor = Convert.ToDecimal(produtoRow["valor"]);

                                string text = $"{descricaoProd} - Quantidade: {quantidade} - Valor: R$ {valor:F2}";
                                BoxPrescrição.Items.Add(text);
                            }
                            else
                            {
                                MessageBox.Show($"Produto com cod_prod {codProd} não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Erro ao processar item do atendimento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado para este atendimento.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                quantidade = (int)TxtQtdade.Value;

                if(string.IsNullOrEmpty(medicamento))
                {
                    throw new Exception("Selecione um medicamento.");
                }
                if(quantidade <= 0)
                {
                    throw new Exception("Informe uma quantidade válida.");
                }

                StringBuilder queryMedicamento = new( );
                queryMedicamento.Append("SELECT cod_prod ");
                queryMedicamento.Append("FROM tb_prod_medic ");
                queryMedicamento.Append($"WHERE descricao_prod = '{medicamento}';");

                connection.StrSql = queryMedicamento.ToString( );
                DataSet dsProduto = connection.RetornarDatase("dbclinica");

                if(dsProduto.Tables.Count > 0 && dsProduto.Tables[0].Rows.Count > 0)
                {
                    DataTable dtProduto = dsProduto.Tables[0];
                    int cod_prod = Convert.ToInt32(dtProduto.Rows[0]["cod_prod"]);

                    StringBuilder queryInsert = new( );
                    queryInsert.Append("INSERT INTO tb_itens_atendimento ");
                    queryInsert.Append("(nr_atendimento, cod_prod, quantidade) ");
                    queryInsert.Append($"VALUES ({CodigoAtendimento}, {cod_prod}, {quantidade});");

                    connection.StrSql = queryInsert.ToString( );
                    connection.ExecutarCmd("dbclinica");

                    MessageBox.Show("Medicamento adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getInfoAtendimento( );
                }
                else
                {
                    throw new Exception("Medicamento não encontrado.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicamento = CbMedicamento.SelectedItem?.ToString( ) ?? string.Empty;
        }

        private void GetMedicamentos()
        {
            try
            {
                StringBuilder queryMedicamentos = new( );
                queryMedicamentos.Append("SELECT descricao_prod ");
                queryMedicamentos.Append("FROM tb_prod_medic;");

                connection.StrSql = queryMedicamentos.ToString( );
                DataSet dsMedicamentos = connection.RetornarDatase("dbclinica");

                if(dsMedicamentos.Tables.Count > 0 && dsMedicamentos.Tables[0].Rows.Count > 0)
                {
                    DataTable dtMedicamentos = dsMedicamentos.Tables[0];

                    foreach(DataRow medicamentoRow in dtMedicamentos.Rows)
                    {
                        CbMedicamento.Items.Add(medicamentoRow["descricao_prod"].ToString( ));
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum medicamento encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
