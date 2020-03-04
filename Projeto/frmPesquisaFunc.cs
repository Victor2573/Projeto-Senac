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
    public partial class frmPesquisaFunc : Form
    {
        public frmPesquisaFunc()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            DataGridViewRow Linha;
            Linha = dgvFuncionario.CurrentRow;

            Clientes.codigo =
                Linha.Cells["Fun_CD"].Value.ToString();
            Funcionarios.nome =
                Linha.Cells["Fun_NM"].Value.ToString();
            Funcionarios.email =
                Linha.Cells["Fun_Email"].Value.ToString();
            Funcionarios.telefone =
                Linha.Cells["Fun_Tel"].Value.ToString();
            Funcionarios.celular =
                Linha.Cells["Fun_Cel"].Value.ToString();
            Funcionarios.rg =
                Linha.Cells["Fun_RG"].Value.ToString();
            Funcionarios.cpf =
                Linha.Cells["Fun_CPF"].Value.ToString();
            Funcionarios.datacontratacao =
                Linha.Cells["Fun_DTContratacao"].Value.ToString();
            Close();
        }

        private void frmPesquisaFunc_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM Funcionarios";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                dt.Load(cmd.ExecuteReader());
                dgvFuncionario.DataSource = dt;
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
}
