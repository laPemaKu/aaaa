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
        private Student student1;
        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }
        public Student Student1
        {
            get
            {
                return student1;
            }
            set
            {
                student1 = value;
            }

        }
        
        private void btnSnimi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
