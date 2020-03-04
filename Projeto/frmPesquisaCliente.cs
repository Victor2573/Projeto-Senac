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
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM Cliente";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                dt.Load(cmd.ExecuteReader());
                dgvCliente.DataSource = dt;
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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Linha;
            Linha = dgvCliente.CurrentRow;

            Clientes.codigo =
                Linha.Cells["Cli_CD"].Value.ToString();
            Clientes.nome =
                Linha.Cells["Cli_Nome"].Value.ToString();
            Clientes.telefone =
                Linha.Cells["Cli_Tel"].Value.ToString();
            Clientes.celular =
                Linha.Cells["Cli_Cel"].Value.ToString();
            Clientes.datanascimento =
                Linha.Cells["Cli_DTNA"].Value.ToString();
            Clientes.cep =
                Linha.Cells["Cli_CEP"].Value.ToString();
            Clientes.estado =
                Linha.Cells["Cli_Estado"].Value.ToString();
            Clientes.cidade =
                Linha.Cells["Cli_Cidade"].Value.ToString();
            Clientes.bairro =
                Linha.Cells["Cli_Bairro"].Value.ToString();
            Clientes.complemento =
                Linha.Cells["Cli_Complemento"].Value.ToString();
            Clientes.rua =
                Linha.Cells["Cli_Rua"].Value.ToString();
            Clientes.numero =
                Linha.Cells["Cli_Numero"].Value.ToString();
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
