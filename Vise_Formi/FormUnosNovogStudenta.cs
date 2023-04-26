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
    public partial class FormUnosNovogStudenta : Form
    {
        private Student student1 = new Student();

        internal Student Student1 { get => student1; set => student1 = value; }

        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Student1.Ime = txtIme.Text;
            Student1.Prezime = txtPrezime.Text;
            Student1.Brojindeksa = txtBrojIndeksa.Text;
            Student1.Smjer = cbxSmjer.Text;
            Student1.DatumRodjenja = Convert.ToDateTime(dtpDatumRodjenja.Text);
        }
    }
}
