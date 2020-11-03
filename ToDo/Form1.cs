using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class frmKezdo : Form
    {
        public frmKezdo()
        {
            InitializeComponent();
        }

        private void mKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmKezdo_Shown(object sender, EventArgs e)
        {
            tbBevitel.Text = "";
            lbToDo.Items.Clear();
            tbBevitel.Focus();
        }

        private void btnListabol_Click(object sender, EventArgs e)
        {
            frmLista fromLista = new frmLista();
            fromLista.ShowDialog();
        }
    }
}