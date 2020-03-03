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
    public partial class frmPesquisaLogin : Form
    {
        public frmPesquisaLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"SELECT * FROM Login_Projeto
                     WHERE Usuario LIKE '" + txtUsuario.Text + "%'";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                dt.Load(cmd.ExecuteReader());
                dgvUsuariosLogin.DataSource = dt;
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Linha;
            Linha = dgvUsuariosLogin.CurrentRow;

            Login.codigo =
                Linha.Cells["CD"].Value.ToString();
            Login.usuario =
                Linha.Cells["Usuario"].Value.ToString();
            Login.senha =
                Linha.Cells["Senha"].Value.ToString();
            Login.tipousuario =
                Linha.Cells["Tipo_Usuario"].Value.ToString();
            Close();
        }
    }
}
