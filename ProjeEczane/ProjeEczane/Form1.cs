using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeEczane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaGirisBtn_Click(object sender, EventArgs e)
        {
            HastaGirisEkrani hastaForm = new HastaGirisEkrani();
            hastaForm.ShowDialog();
        }

        private void doktorGirisBtn_Click(object sender, EventArgs e)
        {
            DoktorGirisEkrani doktorForm = new DoktorGirisEkrani();
            doktorForm.ShowDialog();
        }

        private void eczaciGirisBtn_Click(object sender, EventArgs e)
        {
            EczaciGirisEkrani eczaciForm = new EczaciGirisEkrani();
            eczaciForm.ShowDialog();
        }

        private void ureticiGirisBtn_Click(object sender, EventArgs e)
        {
            UreticiGirisEkrani ureticiForm = new UreticiGirisEkrani();
            ureticiForm.ShowDialog();
        }
    }
}
