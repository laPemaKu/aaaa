using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vise_Formi
{
    public partial class FormStudenti : Form
    {
        public FormStudenti()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();

            DialogResult rez = frm.ShowDialog();

            // unos novog studenta u listBox

            if (rez == System.Windows.Forms.DialogResult.OK)

                lbxStudenti.Items.Add(frm.Student1.ToString());
        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            lbxStudenti.Items.RemoveAt(lbxStudenti.Items.Count -1);
        }

        private void btnObrisiSve_Click(object sender, EventArgs e)
        {
            lbxStudenti.Items.Clear();
        }
    }
}
