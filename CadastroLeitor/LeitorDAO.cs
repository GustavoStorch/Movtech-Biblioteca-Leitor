﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool IsValidEmail(LeitorModel leitor)
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(leitor.Email);
                return email.Address == leitor.Email;
            }
            catch
            {
                MessageBox.Show("Formato de e-mail inválido!");
                return false;
            }
        }

        public bool VerificaCampos(LeitorModel leitor)
        {
            if (string.IsNullOrEmpty(leitor.NomeLeitor) || string.IsNullOrWhiteSpace(leitor.NomeLeitor))
            {
                MessageBox.Show("Informe o campo do nome do leitor");
                return false;
            }
             else if (string.IsNullOrEmpty(leitor.Sexo) || string.IsNullOrWhiteSpace(leitor.Sexo))
            {
                MessageBox.Show("Informe o campo do Sexo do leitor");
                return false;
            }
            else if (string.IsNullOrEmpty(leitor.DataNascimento) || string.IsNullOrWhiteSpace(leitor.DataNascimento))
            {
                MessageBox.Show("Informe o campo da Data de Nascimento do leitor");
                return false;
            }
            else if (string.IsNullOrEmpty(leitor.Endereco) || string.IsNullOrWhiteSpace(leitor.Endereco))
            {
                MessageBox.Show("Informe o campo do Endereco do leitor");
                return false;
            }
            else if (string.IsNullOrEmpty(leitor.EnderecoBairro) || string.IsNullOrWhiteSpace(leitor.EnderecoBairro))
            {
                MessageBox.Show("Informe o campo do bairro do leitor");
                return false;
            }
            else if (string.IsNullOrEmpty(leitor.EnderecoCidade) || string.IsNullOrWhiteSpace(leitor.EnderecoCidade))
            {
                MessageBox.Show("Informe o campo da cidade do leitor");
                return false;
            }
            else if (string.IsNullOrEmpty(leitor.EnderecoUf) || string.IsNullOrWhiteSpace(leitor.EnderecoUf))
            {
                MessageBox.Show("Informe o campo do UF do leitor");
                return false;
            }

            return true;
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
                sql.AppendLine("SELECT codLeitor, nomeLeitor, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, endereco, ");
                sql.AppendLine("enderecoBairro, enderecoCidade, enderecoCep, enderecoUf, enderecoNumero FROM mvtBibLeitor ORDER BY codLeitor");
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
            string sexo = "";
            string dataNascimento = "";
            string cpf = "";
            string rg = "";
            string email = "";
            string telefone = "";
            string telefoneCelular = "";
            string endereco = "";
            string enderecoBairro = "";
            string enderecoCidade = "";
            string enderecoCep = "";
            string enderecoUf = "";
            string enderecoNumero = "";

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
            if (DBNull.Value != dr["sexo"])
            {
                sexo = dr["sexo"] + "";
            }
            if (DBNull.Value != dr["dataNascimento"])
            {
                dataNascimento = dr["dataNascimento"] + "";
            }
            if (DBNull.Value != dr["rg"])
            {
                rg = dr["rg"] + "";
            }
            if (DBNull.Value != dr["email"])
            {
                email = dr["email"] + "";
            }
            if (DBNull.Value != dr["telefone"])
            {
                telefone = dr["telefone"] + "";
            }
            if (DBNull.Value != dr["telefoneCelular"])
            {
                telefoneCelular = dr["telefoneCelular"] + "";
            }
            if (DBNull.Value != dr["endereco"])
            {
                endereco = dr["endereco"] + "";
            }
            if (DBNull.Value != dr["enderecoBairro"])
            {
                enderecoBairro = dr["enderecoBairro"] + "";
            }
            if (DBNull.Value != dr["enderecoCidade"])
            {
                enderecoCidade = dr["enderecoCidade"] + "";
            }
            if (DBNull.Value != dr["enderecoCep"])
            {
                enderecoCep = dr["enderecoCep"] + "";
            }
            if (DBNull.Value != dr["enderecoUf"])
            {
                enderecoUf = dr["enderecoUf"] + "";
            }
            if (DBNull.Value != dr["enderecoNumero"])
            {
                enderecoNumero = dr["enderecoNumero"] + "";
            }

            return new LeitorModel()
            {
                CodLeitor = codLeitor,
                NomeLeitor = nomeLeitor,
                Cpf = cpf,
                Sexo = sexo,
                DataNascimento = dataNascimento,
                Rg = rg,
                Email = email,
                Telefone = telefone,
                TelefoneCelular = telefoneCelular,
                Endereco = endereco,
                EnderecoBairro = enderecoBairro,
                EnderecoCidade = enderecoCidade,
                EnderecoCep = enderecoCep,
                EnderecoUf = enderecoUf,
                EnderecoNumero = enderecoNumero
            };
        }
    }
}