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
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o Login");
                txtLogin.Focus();
            }
            else if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com a Senha");
                txtSenha.Focus();
            }
            else if (cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Entre com o Tipo de Usuário");
                cmbTipoUsuario.Focus();
            }
            else
            {
                try
                {
                    // Abrir a Conexão
                    Conexao.Conectar();

                    string sql = @"select * from Login_Projeto
                                where Usuario =@usuario and Senha =@senha
                                and Tipo_Usuario =@tipo";
                    SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                    cmd.Parameters.AddWithValue("usuario", txtLogin.Text);
                    cmd.Parameters.AddWithValue("senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("tipo", cmbTipoUsuario.SelectedItem);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Login efetuado com sucesso!");
                        Visible = false;
                        frmMenu menu = new frmMenu();
                        menu.ShowDialog();
                        Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha incorretos!");
                    }

                    dr.Close();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmCadastroLogin login = new frmCadastroLogin();
            login.ShowDialog();
            Visible = true;
        }
    }
}
