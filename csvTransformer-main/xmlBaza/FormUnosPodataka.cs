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
    public partial class FormUnosPodataka : Form
    {
        //instaciranje liste u koju ćemo spremati objekte klase Ucenik
        List<Ucenik> listaUcenika = new List<Ucenik>();

        //definiranje putanje i dokumenta u koji ćemo spremati podatke
        String putanja = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "csvTransformerPodaci");

        public FormUnosPodataka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(putanja))
            {
                Directory.CreateDirectory(putanja);
            }

            StreamWriter sw = new StreamWriter(putanja + "/podaci.csv");
            sw.WriteLine("Ime,Prezime,Email,Razred");
            foreach(Ucenik uc in listaUcenika)
            {
                sw.Write(uc.Ispis());
            }
            sw.Close();

            this.Close();
        }

        private void btnUnosPodataka_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailUnos.Text.Contains('@'))
                {
                    Ucenik objUcenik = new Ucenik(txtImeUnos.Text, txtPrezimeUnos.Text, txtEmailUnos.Text, cmbRazredUnos.Text);
                    listaUcenika.Add(objUcenik);
                    txtImeUnos.Clear();
                    txtPrezimeUnos.Clear();
                    txtEmailUnos.Clear();
                    MessageBox.Show("Podaci su uneseni!", "Unos uspješan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unesite ispravnu e-mail adresu.", "Unos nije OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška");
            }
        }
    }
    
}
