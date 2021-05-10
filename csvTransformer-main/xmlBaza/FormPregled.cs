using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace csvTransformer
{
    public partial class FormPregled : Form
    {
        public FormPregled()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            FormFiltriranje frmFiltriranje = new FormFiltriranje();
            frmFiltriranje.Show();
        }

        private void BtnUcitajDokument_Click(object sender, EventArgs e)
        {
            rtbIspisPodataka.Text = "";
            string lokacija = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "csvTransformerPodaci");

            if (!File.Exists(lokacija))
            {
                Directory.CreateDirectory(lokacija);
            }
            StreamReader sw = new StreamReader(lokacija + "/podaci.csv");
            string saved_data = sw.ReadToEnd();
            string[] podaci = saved_data.Split(',');
            for (int i = 0; i < podaci.Length; i++)
            {
                rtbIspisPodataka.Text += $"{podaci[i]}  ";
            }
            sw.Close();
        }
    }
}
