using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmAgendamento agenda = new frmAgendamento();
            agenda.TopLevel = false;
            agenda.AutoScroll = true;
            panel1.Controls.Add(agenda);
            agenda.FormBorderStyle = FormBorderStyle.None;
            agenda.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmCadCliente cliente = new frmCadCliente();
            cliente.ShowDialog();
            Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
