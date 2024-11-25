using Estoque;

namespace proj_clinica
{
    public partial class FormMenu : BaseForm
    {
        public FormMenu()
        {
            InitializeComponent( );
            CreateDatabaseAndTable( );
        }

        private static void CreateDatabaseAndTable()
        {
            try
            {
                var connection = new ClsConexao( );

                var dbTableScripts = GetTableCreationScripts( );
                connection.CriarBancoETabela("dbclinica", dbTableScripts);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao criar banco de dados e tabelas:\n{ex.Message}");
            }
        }

        private static string[] GetTableCreationScripts()
        {
            return new[]
            {
                @"CREATE TABLE IF NOT EXISTS tb_paciente (
                    cod_paciente INT AUTO_INCREMENT PRIMARY KEY,
                    nome_paciente VARCHAR(100) NOT NULL,
                    cpf_paciente CHAR(11) NOT NULL UNIQUE,
                    celular_paciente CHAR(11) NOT NULL
                );",

                @"CREATE TABLE IF NOT EXISTS tb_especialidade (
                    cod_espec INT AUTO_INCREMENT PRIMARY KEY,
                    descricao varchar(40) not null unique
                );",

                @"CREATE TABLE IF NOT EXISTS tb_medico (
                    crm_medico INT PRIMARY KEY,
                    nome_medico VARCHAR(100) NOT NULL,
                    cpf_medico CHAR(11) NOT NULL UNIQUE,
                    celular_medico CHAR(11) NOT NULL,
                    cod_espec INT NOT NULL,
                    FOREIGN KEY (cod_espec) REFERENCES tb_especialidade(cod_espec)
                        ON DELETE CASCADE
                        ON UPDATE CASCADE
                );",

                @"CREATE TABLE IF NOT EXISTS tb_prod_medic (
                    cod_prod INT AUTO_INCREMENT PRIMARY KEY,
                    descricao_prod VARCHAR(50) NOT NULL UNIQUE,
                    valor DECIMAL(4,2) NOT NULL,
                    validade TIMESTAMP NOT NULL,
                    quantidade int not null default(0)
                );",

                @"CREATE TABLE IF NOT EXISTS tb_atendimento (
                    nr_atendimento INT AUTO_INCREMENT PRIMARY KEY,
                    cod_paciente INT NOT NULL,
                    data_atendimento TIMESTAMP NOT NULL,
                    crm_medico INT NOT NULL,
                    FOREIGN KEY (cod_paciente) REFERENCES tb_paciente(cod_paciente)
                        ON DELETE CASCADE
                        ON UPDATE CASCADE,
                    FOREIGN KEY (crm_medico) REFERENCES tb_medico(crm_medico)
                        ON DELETE CASCADE
                        ON UPDATE CASCADE
                );",

                @"CREATE TABLE IF NOT EXISTS tb_itens_atendimento (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nr_atendimento INT NOT NULL,
                    cod_prod INT NOT NULL,
                    quantidade INT NOT NULL,
                    FOREIGN KEY (nr_atendimento) REFERENCES tb_atendimento(nr_atendimento)
                        ON DELETE CASCADE
                        ON UPDATE CASCADE,
                    FOREIGN KEY (cod_prod) REFERENCES tb_prod_medic(cod_prod)
                        ON DELETE CASCADE
                        ON UPDATE CASCADE
                );"
            };
        }

        private void OpenForm<T>() where T : Form, new()
        {
            using var form = new T( );
            form.ShowDialog( );
        }

        private void PacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormPaciente>( );
        }

        private void MedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormMedico>( );
        }

        private void MedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormProduto>( );
        }

        private void BtnAtendimento_Click(object sender, EventArgs e)
        {
            OpenForm<FormAtendimento>( );
        }
    }
}
