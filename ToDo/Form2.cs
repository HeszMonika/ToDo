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
    public partial class frmLista : Form
    {
        public string SelectedToDo { get; set; }

        public frmLista(List<string> todos)
        {
            InitializeComponent();

            lbTargyak.Items.Clear();
            foreach (var t in todos)
            {
                lbTargyak.Items.Add(t);
            }
        }

        private void lbTargyak_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            SelectedToDo = lbTargyak.SelectedItem.ToString();
            this.Close();
        }

        private void frmLista_Shown(object sender, EventArgs e)
        {
            lbTargyak.SelectedIndex = 0;
        }
    }
}