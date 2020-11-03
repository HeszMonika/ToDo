using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDo
{
    public partial class frmKezdo : Form
    {
        private List<string> todos = new List<string>();

        public frmKezdo()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("todoitems.txt");
            while (!sr.EndOfStream)
            {
                todos.Add(sr.ReadLine());
            }
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
            frmLista formLista = new frmLista(todos);
            var result = formLista.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbBevitel.Text = formLista.SelectedToDo;
            }
            tbBevitel.Focus();
            tbBevitel.SelectionStart = tbBevitel.Text.Length;
            tbBevitel.SelectionLength = 0;
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            string todo = tbBevitel.Text.Trim();
            if (todo != "" && !lbToDo.Items.Contains(todo))
            {
                lbToDo.Items.Add(todo);
                tbBevitel.Text = "";
            }
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            lbToDo.Items.Clear();
        }

        private void btnKivesz_Click(object sender, EventArgs e)
        {
            int index = lbToDo.SelectedIndex;
            if (index > -1)
            {
                lbToDo.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Válassz egy elemet!", "Nincs kiválasztva.", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void mBeolvasas_Click(object sender, EventArgs e)
        {
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                lbToDo.Items.Clear();
                StreamReader sr = new StreamReader(ofdMegnyitas.FileName);
                while (!sr.EndOfStream)
                {
                    lbToDo.Items.Add(sr.ReadLine());
                }
                sr.Close();
                MessageBox.Show("Sikeres beolvasás.", "Mentés.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string FileNameDate()
        {
            var datum = DateTime.Now;
            string ev = datum.Year.ToString();
            string honap = "";
            if (datum.Month < 10)
            {
                honap = "0" + datum.Month.ToString();
            }
            else
            {
                honap = datum.Month.ToString();
            }
            string nap = "";
            if (datum.Day < 10)
            {
                nap = "0" + datum.Day.ToString();
            }
            else
            {
                nap = datum.Day.ToString();
            }

            return ev + honap + nap;
        }

        private void mMentes_Click(object sender, EventArgs e)
        {
            if (sfdMentes.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfdMentes.FileName);
                foreach (var item in lbToDo.Items)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
                MessageBox.Show("Sikeres mentés.", "Mentés.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}