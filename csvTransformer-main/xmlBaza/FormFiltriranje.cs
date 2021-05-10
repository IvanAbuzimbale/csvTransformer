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
    public partial class FormFiltriranje : Form
    {
        public FormFiltriranje()
        {
            InitializeComponent();
        }

        private void btnOdustaniFilter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrirajPodatke_Click(object sender, EventArgs e)
        {

        }
    }
}
