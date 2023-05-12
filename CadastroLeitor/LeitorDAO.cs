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
                    sql.AppendLine($"INSERT INTO mvtBibLeitor(nomeLeitor, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, ");
                    sql.AppendLine($"endereco, enderecoBairro, enderecoCidade, enderecoCep, enderecoUf, enderecoNumero) ");
                    sql.AppendLine($"VALUES (@nomeLeitor, @sexo, @dataNascimento, @cpf, @rg, @email, @telefone, @telefoneCelular, @endereco, @enderecoBairro, @enderecoCidade, ");
                    sql.AppendLine($"@enderecoCep, @enderecoUf, @enderecoNumero)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@nomeLeitor", leitor.NomeLeitor));
                    command.Parameters.Add(new SqlParameter("@sexo", leitor.Sexo));
                    command.Parameters.Add(new SqlParameter("@dataNascimento", leitor.DataNascimento));
                    command.Parameters.Add(new SqlParameter("@cpf", leitor.Cpf));
                    command.Parameters.Add(new SqlParameter("@rg", leitor.Rg));
                    command.Parameters.Add(new SqlParameter("@email", leitor.Email));
                    command.Parameters.Add(new SqlParameter("@telefone", leitor.Telefone));
                    command.Parameters.Add(new SqlParameter("@telefoneCelular", leitor.TelefoneCelular));
                    command.Parameters.Add(new SqlParameter("@endereco", leitor.Endereco));
                    command.Parameters.Add(new SqlParameter("@enderecoBairro", leitor.EnderecoBairro));
                    command.Parameters.Add(new SqlParameter("@enderecoCidade", leitor.EnderecoCidade));
                    command.Parameters.Add(new SqlParameter("@enderecoCep", leitor.EnderecoCep));
                    command.Parameters.Add(new SqlParameter("@enderecoUf", leitor.EnderecoUf));
                    command.Parameters.Add(new SqlParameter("@enderecoNumero", leitor.EnderecoNumero));

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
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibLeitor SET nomeLeitor = @nomeLeitor, sexo = @sexo, dataNascimento = @dataNascimento, " +
                        $"cpf = @cpf, rg = @rg, email = @email, telefone = @telefone, telefoneCelular = @telefoneCelular," +
                        $"endereco = @endereco, enderecoBairro = @enderecoBairro, enderecoCidade = @enderecoCidade, enderecoCep = @enderecoCep," +
                        $"enderecoUf = @enderecoUf, enderecoNumero = @enderecoNumero WHERE codLeitor = @codLeitor");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codLeitor", leitor.CodLeitor);
                    command.Parameters.Add(new SqlParameter("@nomeLeitor", leitor.NomeLeitor));
                    command.Parameters.Add(new SqlParameter("@sexo", leitor.Sexo));
                    command.Parameters.Add(new SqlParameter("@dataNascimento", leitor.DataNascimento));
                    command.Parameters.Add(new SqlParameter("@cpf", leitor.Cpf));
                    command.Parameters.Add(new SqlParameter("@rg", leitor.Rg));
                    command.Parameters.Add(new SqlParameter("@email", leitor.Email));
                    command.Parameters.Add(new SqlParameter("@telefone", leitor.Telefone));
                    command.Parameters.Add(new SqlParameter("@telefoneCelular", leitor.TelefoneCelular));
                    command.Parameters.Add(new SqlParameter("@endereco", leitor.Endereco));
                    command.Parameters.Add(new SqlParameter("@enderecoBairro", leitor.EnderecoBairro));
                    command.Parameters.Add(new SqlParameter("@enderecoCidade", leitor.EnderecoCidade));
                    command.Parameters.Add(new SqlParameter("@enderecoCep", leitor.EnderecoCep));
                    command.Parameters.Add(new SqlParameter("@enderecoUf", leitor.EnderecoUf));
                    command.Parameters.Add(new SqlParameter("@enderecoNumero", leitor.EnderecoNumero));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
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
            List<LeitorModel> leitores = new List<LeitorModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT LEI.codLeitor, LEI.nomeLeitor, LEI.cpf FROM mvtBibLeitor LEI ORDER BY LEI.codLeitor");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        leitores.Add(PopulateDr(dr));
                    }
                }
            }
            return leitores;
        }

        public LeitorModel PopulateDr(SqlDataReader dr)
        {
            string codLeitor = "";
            string nomeLeitor = "";
            string cpf = "";

            if (DBNull.Value != dr["codLeitor"])
            {
                codLeitor = dr["codLeitor"] + "";
            }
            if (DBNull.Value != dr["nomeLeitor"])
            {
                nomeLeitor = dr["nomeLeitor"] + "";
            }
            if (DBNull.Value != dr["cpf"])
            {
                cpf = dr["cpf"] + "";
            }
            return new LeitorModel()
            {
                CodLeitor = codLeitor,
                NomeLeitor = nomeLeitor,
                Cpf = cpf
            };
        }
    }
}