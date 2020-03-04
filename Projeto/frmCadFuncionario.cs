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

namespace Projeto
{
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o Nome do Funcionário");
                txtNome.Focus();
            }
            else if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o email do Funcionário");
                txtEmail.Focus();
            }
            else if (mskCelular.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o Celular do Funcionário");
                mskCelular.Focus();
            }
            else if (mskTelefone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o Telefone do Funcionário");
                mskTelefone.Focus();
            }
            else if (mskRG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o RG do Funcionário");
                mskRG.Focus();
            }
            else if (mskCPF.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o CPF do Funcionário");
                mskCPF.Focus();
            }
            else
            {
                try
                {
                    Conexao.Conectar();
                    string sql = @"INSERT INTO Funcionarios VALUES (@Fun_NM, @Fun_Email, @Fun_Tel, @Fun_Cel, 
                             @Fun_RG, @Fun_CPF, @Fun_DTContratacao)";
                    SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                    // Adicionar os parametros
                    cmd.Parameters.AddWithValue("Fun_NM", txtNome.Text);
                    cmd.Parameters.AddWithValue("Fun_Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("Fun_Tel", mskTelefone.Text);
                    cmd.Parameters.AddWithValue("Fun_Cel", mskCelular.Text);
                    cmd.Parameters.AddWithValue("Fun_RG", mskRG.Text);
                    cmd.Parameters.AddWithValue("Fun_CPF", mskCPF.Text);
                    cmd.Parameters.AddWithValue("Fun_DTContratacao", mskDataContratacao.Text);
                    //Executar o comando do banco de dados
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro do Funcionário Feito com sucesso!");
                    Util.LimparCampos(this);
                    txtNome.Focus();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    Conexao.Desconectar();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            mskDataContratacao.Text = DateTime.Now.ToShortDateString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Funcionarios.codigo = "";
            Visible = false;
            frmPesquisaCliente pesqFuncionarios = new frmPesquisaCliente();
            pesqFuncionarios.ShowDialog();
            Visible = true;
            if (Funcionarios.codigo != "")
            {
                txtNome.Text = Funcionarios.nome;
                txtEmail.Text = Funcionarios.email;
                mskTelefone.Text = Funcionarios.telefone;
                mskCelular.Text = Funcionarios.celular;
                mskRG.Text = Funcionarios.rg;
                mskCPF.Text = Funcionarios.cpf;
                mskDataContratacao.Text = Funcionarios.datacontratacao;
                // Habilitar os botões alterar e excluir
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                //Desabilitar o botão Cadastrar
                btnCadastrar.Enabled = false;
            }
        }
    }
}

