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
    public partial class frmCadastroLogin : Form
    {
        public frmCadastroLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo Login");
                txtUsuario.Focus();
            }
            else if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo Senha");
                txtSenha.Focus();
            }
            else if (cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Tipo de Usuário");
                cmbTipoUsuario.Focus();
            }
            else
            {
                try
                {
                    // Abrir a conexão
                    Conexao.Conectar();
                    string sql = @"INSERT INTO Login_Projeto VALUES (@Usuario,
                                @Senha, @Tipo_Usuario)";
                    SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                    // Adicionar os parâmetros
                    cmd.Parameters.AddWithValue("Usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("Tipo_Usuario", cmbTipoUsuario.SelectedItem);
                    //Executar o comando do banco de dados
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Login cadastrado com sucesso");
                    Util.LimparCampos(this);
                    txtUsuario.Focus();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja realmente alterar o Login?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.No)
                return;
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o Usuário!");
                txtUsuario.Focus();
            }
            else if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha a Senha!");
                txtSenha.Focus();
            }
            else if (cmbTipoUsuario.Text.Trim().Length == -1)
            {
                MessageBox.Show("Escolha um Tipo de Usuário!");

            }
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE Login_Projeto SET Usuario=@Usuario, Senha=@Senha, Tipo_Usuario=@Tipo_Usuario WHERE CD = @Cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // Adicionar os parâmetros
                cmd.Parameters.AddWithValue("Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("Cod", Login.codigo);
                cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("Tipo_Usuario", cmbTipoUsuario.SelectedItem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Login alterado com sucesso");
                Util.LimparCampos(this);
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmPesquisaLogin pesqLeitor = new frmPesquisaLogin();
            pesqLeitor.ShowDialog();
            Visible = true;
            if (Login.codigo != "")
            {
                txtUsuario.Text = Login.usuario;
                txtSenha.Text = Login.senha;
                cmbTipoUsuario.SelectedItem = Login.tipousuario;


                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                btnCadastrar.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja realmente excluir o Login?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.No)
                return;

            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM Login_Projeto
                                WHERE CD = @Cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("Cod", Login.codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Leitor excluido com sucesso");
                Util.LimparCampos(this);
                Login.codigo = "";
                txtUsuario.Focus();
                //Desabilitar os botões excluir e alterar
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                // Habilitar o botão Cadastrar
                btnCadastrar.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
