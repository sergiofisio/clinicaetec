using Estoque;
using System.Data;
using System.Text.RegularExpressions;

namespace proj_clinica.Helpers
{
    internal class Functions
    {
        private readonly ClsConexao connection;

        public Functions(ClsConexao conexao)
        {
            this.connection = conexao;
        }

        public int GetMaxCod(string table, string column, string database)
        {
            try
            {
                connection.StrSql = $"SELECT MAX({SanitizeIdentifier(column)}) AS MaxCod FROM {SanitizeIdentifier(table)}";

                var ds = connection.RetornarDatase(database);

                if(ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["MaxCod"] != DBNull.Value)
                {
                    return Convert.ToInt32(ds.Tables[0].Rows[0]["MaxCod"]) + 1;
                }

                return 1;
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao buscar código: {ex.Message}");
            }
        }

        public DataTable HandleSearch(string table, string[] columns, string database)
        {
            try
            {
                string sanitizedColumns = string.Join(", ", columns.Select(SanitizeIdentifier));
                connection.StrSql = $"SELECT {sanitizedColumns} FROM {SanitizeIdentifier(table)}";

                return connection.RetornarDatase(database).Tables[0];
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao buscar dados: {ex.Message}");
            }
        }

        public string HandleInsert(string table, string[] columns, string[] values, string database)
        {
            try
            {
                string colNames = string.Join(", ", columns.Select(SanitizeIdentifier));
                string paramNames = string.Join(", ", values.Select(value => $"'{value.Replace("'", "''")}'"));

                connection.StrSql = $"INSERT INTO {SanitizeIdentifier(table)} ({colNames}) VALUES ({paramNames})";

                int rowsAffected = connection.ExecutarCmd(database);

                if(rowsAffected > 0)
                    return "Dados inseridos com sucesso!";
                else
                    return "Nenhuma linha foi inserida.";
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao inserir dados: {ex.Message}");
            }
        }

        public string HandleUpdate(string table, string[] columns, string[] values, string whereColumn, string whereValue, string database)
        {
            try
            {
                string setClause = string.Join(", ", columns.Select((col, i) => $"{SanitizeIdentifier(col)}='{values[i].Replace("'", "''")}'"));

                connection.StrSql = $"UPDATE {SanitizeIdentifier(table)} SET {setClause} WHERE {SanitizeIdentifier(whereColumn)}='{whereValue.Replace("'", "''")}'";

                int rowsAffected = connection.ExecutarCmd(database);

                if(rowsAffected > 0)
                    return "Dados atualizados com sucesso!";
                else
                    return "Nenhuma linha foi atualizada.";
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao atualizar dados: {ex.Message}");
            }
        }

        public string HandleDelete(string table, string whereColumn, string whereValue, string database, string type)
        {
            try
            {
                connection.StrSql = $"DELETE FROM {SanitizeIdentifier(table)} WHERE {SanitizeIdentifier(whereColumn)}='{whereValue.Replace("'", "''")}'";

                int rowsAffected = connection.ExecutarCmd(database);

                if(rowsAffected > 0)
                    return $"{type} excluído com sucesso!";
                else
                    return $"Nenhuma linha foi excluída.";
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao excluir {type}: {ex.Message}");
            }
        }

        private static string SanitizeIdentifier(string identifier)
        {
            if(string.IsNullOrWhiteSpace(identifier))
                throw new ArgumentException("Identificador inválido.");

            return $"{identifier.Replace("`", "``")}";
        }

        public string CleanString(string input, string pattern)
        {
            return Regex.Replace(input, pattern, "").Trim( );
        }
    }
}
