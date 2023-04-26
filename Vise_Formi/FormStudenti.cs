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
            // kreiranje nove forme tipa FormUnosNovogStudenta

            FormUnosNovogStudenta frm = new
            FormUnosNovogStudenta();
            // unos novog studenta u listBox

           if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                lbxStudenti.Items.Add("ass");
        }
    }
}
