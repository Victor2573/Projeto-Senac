using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public static class Util
    {
        public static void LimparCampos(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    ((ComboBox)(item)).SelectedIndex = -1;
                }
                else if (item is ListBox)
                {
                    ((ListBox)(item)).Items.Clear();
                }
                if (item.HasChildren)
                {
                    LimparCampos(item);
                }
            }
        }
    }
}