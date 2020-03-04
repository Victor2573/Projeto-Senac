using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto
{
    public partial class frmCadCliente : Form
    {
        public void LocalizarCEP()
        {
            /*
            * https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl 
             */

            using (var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mskCEP.Text);
                    txtBairro.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    cmbEstado.Text = resultado.uf;
                    txtRua.Text = resultado.end;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro " + ex.Message);
                }
            }
        }
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Coloque o nome do Cliente");
                txtNome.Focus();
            }
            else if (mskCelular.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o número do celular do Cliente");
                mskCelular.Focus();
            }
            else if (mskCEP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o CEP do Cliente");
                mskCEP.Focus();
            }
            else if (cmbEstado.Text.Trim().Length == -1)
            {
                MessageBox.Show("Preencha o estado do Cliente");
                cmbEstado.Focus();
            }
            else
            {
                try
                {
                    Conexao.Conectar();
                    string sql = @"INSERT INTO Cliente VALUES (@Cli_Nome, @Cli_Tel, @Cli_Cel, 
                            @Cli_DTNA, @Cli_CEP, @Cli_Bairro, @Cli_Estado, @Cli_Cidade, @Cli_Complemento, @Cli_Rua, @Cli_Numero)";
                    SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                    // Adicionar os parametros
                    cmd.Parameters.AddWithValue("Cli_Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("Cli_Tel", mskTelefone.Text);
                    cmd.Parameters.AddWithValue("Cli_Cel", mskCelular.Text);
                    cmd.Parameters.AddWithValue("Cli_DTNA", mskDataNascimento.Text);
                    cmd.Parameters.AddWithValue("Cli_CEP", mskCEP.Text);
                    cmd.Parameters.AddWithValue("Cli_Bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("Cli_Estado", cmbEstado.Text);
                    cmd.Parameters.AddWithValue("Cli_Cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("Cli_Complemento", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("Cli_Rua", txtRua.Text);
                    cmd.Parameters.AddWithValue("Cli_Numero", txtNumero.Text);
                    //Executar o comando do banco de dados
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro do Cliente Feito com sucesso!");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja realmente alterar o Cadastro do Cliente?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.No)
                return;
            if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Coloque o nome do Cliente");
                txtNome.Focus();
            }
            else if (mskCelular.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o número do celular do Cliente");
                mskCelular.Focus();
            }
            else if (mskCEP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o CEP do Cliente");
                mskCEP.Focus();
            }
            else if (cmbEstado.Text.Trim().Length == -1)
            {
                MessageBox.Show("Preencha o estado do Cliente");
                cmbEstado.Focus();
            }
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE  Cliente SET Cli_Nome=@Nome, Cli_Tel=@Telefone, Cli_Cel=@Celular, 
                            Cli_DTNA=@Data_Nascimento, Cli_CEP=@CEP, Cli_Bairro=@Bairro, Cli_Estado=@Estado, Cli_Cidade=@Cidade, Cli_Complemento=@Complemento, Cli_Rua=@Rua, Cli_Numero=@Numero WHERE Cli_CD = @Codigo)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // Adicionar os parametros
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Telefone", mskTelefone.Text);
                cmd.Parameters.AddWithValue("Celular", mskCelular.Text);
                cmd.Parameters.AddWithValue("Data_Nascimento", mskDataNascimento.Text);
                cmd.Parameters.AddWithValue("CEP", mskCEP.Text);
                cmd.Parameters.AddWithValue("Bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("Estado", cmbEstado.SelectedItem);
                cmd.Parameters.AddWithValue("Cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("Complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("Rua", txtRua.Text);
                cmd.Parameters.AddWithValue("Numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("Codigo", Clientes.codigo);
                //Executar o comando do banco de dados
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro do Cliente Alterado com sucesso!");
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja realmente excluir o Cadastro do Cliente?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.No)
                return;

            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM Cliente
                                WHERE Cli_CD = @Codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("Codigo", Clientes.codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluido com sucesso!");
                Util.LimparCampos(this);
                Clientes.codigo = "";
                txtNome.Focus();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Clientes.codigo = "";
            Visible = false;
            frmPesquisaCliente pesqCliente = new frmPesquisaCliente();
            pesqCliente.ShowDialog();
            Visible = true;
            if (Clientes.codigo != "")
            {
                txtNome.Text = Clientes.nome;
                mskTelefone.Text = Clientes.telefone;
                mskCelular.Text = Clientes.celular;
                mskDataNascimento.Text = Clientes.datanascimento;
                mskCEP.Text = Clientes.cep;
                txtBairro.Text = Clientes.bairro;
                cmbEstado.SelectedItem = Clientes.estado;
                txtCidade.Text = Clientes.cidade;
                txtComplemento.Text = Clientes.complemento;
                txtRua.Text = Clientes.rua;
                txtNumero.Text = Clientes.numero;
                // Habilitar os botões alterar e excluir
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                //Desabilitar o botão Cadastrar
                btnCadastrar.Enabled = false;
            }
        }
    }
}

