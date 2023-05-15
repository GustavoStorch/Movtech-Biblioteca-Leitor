using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroLeitor
{
    public partial class FormCadLeitor : Form
    {
        public FormCadLeitor()
        {
            InitializeComponent();
        }

        private void FormCadLeitor_Load(object sender, EventArgs e)
        {
            InitializeTable();
            CarregaID();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtCodLeitor.Text) || string.IsNullOrWhiteSpace(txtCodLeitor.Text))
            {
                MessageBox.Show("Informe o campo do Código do leitor");
                return;
            }
            else if (string.IsNullOrEmpty(txtNomeLeitor.Text) || string.IsNullOrWhiteSpace(txtNomeLeitor.Text))
            {
                MessageBox.Show("Informe o campo do nome do leitor");
                return;
            }*/

            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    LeitorDAO dao = new LeitorDAO(connection);
                    bool verificaCampos = dao.VerificaCampos(new LeitorModel()
                    {
                        NomeLeitor = txtNomeLeitor.Text,
                        Sexo = cbxSexoLeitor.Text,
                        DataNascimento = txtDtNascimento.Text,
                        Endereco = txtEnderecoLeitor.Text,
                        EnderecoBairro = txtBairroLeitor.Text,
                        EnderecoCidade = txtCidadeLeitor.Text,
                        EnderecoUf = txtUfLeitor.Text
                    });

                    bool verificaEmail = dao.IsValidEmail(new LeitorModel()
                    {
                        Email = txtEmailleitor.Text
                    });

                    if(verificaCampos && verificaEmail)
                    {
                        int count = dao.VerificaRegistros(new LeitorModel()
                        {
                            CodLeitor = txtCodLeitor.Text
                        });

                        if (count > 0)
                        {
                            dao.Editar(new LeitorModel()
                            {
                                CodLeitor = txtCodLeitor.Text,
                                NomeLeitor = txtNomeLeitor.Text,
                                Sexo = cbxSexoLeitor.Text,
                                DataNascimento = txtDtNascimento.Text,
                                Cpf = txtCpfLeitor.Text.Replace(",", "").Replace("-", ""),
                                Rg = txtRgLeitor.Text.Replace(",", "").Replace("-", ""),
                                Email = txtEmailleitor.Text,
                                Telefone = txtTelefoneLeitor.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace("-", "").Replace(" ", ""),
                                TelefoneCelular = txtCelularLeitor.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace("-", "").Replace(" ", ""),
                                Endereco = txtEnderecoLeitor.Text,
                                EnderecoBairro = txtBairroLeitor.Text,
                                EnderecoCidade = txtCidadeLeitor.Text,
                                EnderecoCep = txtCepLeitor.Text.Replace("-", ""),
                                EnderecoUf = txtUfLeitor.Text,
                                EnderecoNumero = txtNumeroLeitor.Text,
                            });
                            MessageBox.Show("leitor Atualizada com sucesso!");
                            limparForm();
                        }
                        else
                        {
                            dao.Salvar(new LeitorModel()
                            {
                                NomeLeitor = txtNomeLeitor.Text,
                                Sexo = cbxSexoLeitor.Text,
                                DataNascimento = txtDtNascimento.Text,
                                Cpf = txtCpfLeitor.Text.Replace(",", "").Replace("-", ""),
                                Rg = txtRgLeitor.Text.Replace(",", "").Replace("-", ""),
                                Email = txtEmailleitor.Text,
                                Telefone = txtTelefoneLeitor.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                                TelefoneCelular = txtCelularLeitor.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace("-", "").Replace(" ", ""),
                                Endereco = txtEnderecoLeitor.Text,
                                EnderecoBairro = txtBairroLeitor.Text,
                                EnderecoCidade = txtCidadeLeitor.Text,
                                EnderecoCep = txtCepLeitor.Text.Replace("-", ""),
                                EnderecoUf = txtUfLeitor.Text,
                                EnderecoNumero = txtNumeroLeitor.Text,
                            });
                            MessageBox.Show("leitor salva com sucesso!");
                            limparForm();
                        }
                    }   
                }
                InitializeTable();
                CarregaID();
                btnExcluir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o leitor!\n{ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeLeitor.Text))
            {
                MessageBox.Show("Escolha um Leitor!");
                return;
            }

            DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir o leitor?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (conf == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        LeitorDAO dao = new LeitorDAO(connection);
                        dao.Excluir(new LeitorModel()
                        {
                            CodLeitor = txtCodLeitor.Text
                        });
                    }
                    MessageBox.Show("Leitor excluído com sucesso!");
                    InitializeTable();
                    limparForm();
                    CarregaID();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir o leitor!\n{ex.Message}");
            }
        }

        public void limparForm()
        {
            txtCodLeitor.Text = String.Empty;
            txtNomeLeitor.Text = String.Empty;
            cbxSexoLeitor.Text = String.Empty;
            txtDtNascimento.Text = String.Empty;
            txtCpfLeitor.Text = String.Empty;
            txtRgLeitor.Text = String.Empty;
            txtEmailleitor.Text = String.Empty;
            txtTelefoneLeitor.Text = String.Empty;
            txtCelularLeitor.Text = String.Empty;
            txtEnderecoLeitor.Text = String.Empty;
            txtBairroLeitor.Text = String.Empty;
            txtCidadeLeitor.Text = String.Empty;    
            txtCepLeitor.Text = String.Empty;
            txtUfLeitor.Text = String.Empty;
            txtNumeroLeitor.Text = String.Empty;
        }

        private void InitializeTable()
        {
            dtgDadosLeitor.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LeitorDAO dao = new LeitorDAO(connection);
                List<LeitorModel> leitores = dao.GetLeitores();
                foreach (LeitorModel leitor in leitores)
                {
                    DataGridViewRow row = dtgDadosLeitor.Rows[dtgDadosLeitor.Rows.Add()];
                    row.Cells[colCodigoLeitor.Index].Value = leitor.CodLeitor;
                    row.Cells[colNomeLeitor.Index].Value = leitor.NomeLeitor;
                    row.Cells[colCpfLeitor.Index].Value = leitor.Cpf;
                    row.Cells[colSexoLeitor.Index].Value = leitor.Sexo;
                    row.Cells[colDtNascimentoLeitor.Index].Value = leitor.DataNascimento;
                    row.Cells[colRgLeitor.Index].Value = leitor.Rg;
                    row.Cells[colEmailLeitor.Index].Value = leitor.Email;
                    row.Cells[colTelefoneLeitor.Index].Value = leitor.Telefone;
                    row.Cells[colCelularLeitor.Index].Value = leitor.TelefoneCelular;
                    row.Cells[colEnderecoLeitor.Index].Value = leitor.Endereco;
                    row.Cells[colBairroLeitor.Index].Value = leitor.EnderecoBairro;
                    row.Cells[colCidadeLeitor.Index].Value = leitor.EnderecoCidade;
                    row.Cells[colCepLeitor.Index].Value = leitor.EnderecoCep;
                    row.Cells[colUfLeitor.Index].Value = leitor.EnderecoUf;
                    row.Cells[colNumeroLeitor.Index].Value = leitor.EnderecoNumero;
                }
            }
        }

        private void CarregaID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('mvtBibLeitor') + 1", connection);
                int nextCod = Convert.ToInt32(command.ExecuteScalar());

                txtCodLeitor.Text = nextCod.ToString();
            }
        }

        private void dtgDadosLeitor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colCodigoLeitor.Index].Value + "";
                txtNomeLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colNomeLeitor.Index].Value + "";
                txtCpfLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colCpfLeitor.Index].Value + "";
                cbxSexoLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colSexoLeitor.Index].Value + "";
                txtDtNascimento.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colDtNascimentoLeitor.Index].Value + "";
                txtRgLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colRgLeitor.Index].Value + "";
                txtEmailleitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colEmailLeitor.Index].Value + "";
                txtTelefoneLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colTelefoneLeitor.Index].Value + "";
                txtCelularLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colCelularLeitor.Index].Value + "";
                txtEnderecoLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colEnderecoLeitor.Index].Value + "";
                txtBairroLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colBairroLeitor.Index].Value + "";
                txtCidadeLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colCidadeLeitor.Index].Value + "";
                txtCepLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colCepLeitor.Index].Value + "";
                txtUfLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colUfLeitor.Index].Value + "";
                txtNumeroLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colNumeroLeitor.Index].Value + "";
                if (string.IsNullOrEmpty(this.txtNomeLeitor.Text))
                {
                    btnExcluir.Enabled = false;
                    CarregaID();
                }
                else
                {
                    btnExcluir.Enabled = true;
                }
            }
        }
    }
}
