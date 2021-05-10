using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvTransformer
{
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            FormUnosPodataka frmUnos = new FormUnosPodataka();
            frmUnos.Show();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            FormPregled frmPregled = new FormPregled();
            frmPregled.Show();
        }
    }
}
