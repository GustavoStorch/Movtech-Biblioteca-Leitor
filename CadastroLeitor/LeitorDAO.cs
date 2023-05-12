using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLeitor
{
    public class LeitorDAO
    {
        private SqlConnection Connection { get; }

        public LeitorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(LeitorModel leitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibItemAcervo(nomeLeitor, sexo, dataNascimento, cpf) VALUES @nomeLeitor, @sexo," +
                        $" @dataNascimento, @cpf");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codLocal", itemAcervo.CodLocal));

                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch(Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Editar(LeitorModel leitor)
        {

        }

        public void Excluir(LeitorModel leitor, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibLeitor WHERE codLeitor = @codLeitor");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codLeitor", leitor.CodLeitor));
                command.ExecuteNonQuery();
            }
        }

        public int VerificaRegistros(LeitorModel leitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codLeitor) FROM mvtBibLeitor WHERE codLeitor = @codLeitor");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codLeitor", leitor.CodLeitor);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }

        public List<LeitorModel> GetLeitores()
        {
            return null;
        }

        public LeitorModel PopulateDr(SqlDataReader dr)
        {
            return null;
        }
    }
}
}
