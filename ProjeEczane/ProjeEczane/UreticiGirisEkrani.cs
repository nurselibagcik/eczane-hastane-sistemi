using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeEczane
{
    public partial class UreticiGirisEkrani : Form
    {
        public UreticiGirisEkrani()
        {
            InitializeComponent();
        }
        private void urtgrsbtn_Click(object sender, EventArgs e)
        {
            String e_posta = epsttextBox.Text;
            String sifre = urtcsfrtextBox.Text;
            SqlCommand ureticiListe = new SqlCommand(
       "SELECT ManufacturerID FROM Manufacturers WHERE ContactInfo = @ContactInfo AND ManifPass = @ManifPass",
       sqlOperations.conn);

            sqlOperations.checkConn(sqlOperations.conn);

            ureticiListe.Parameters.AddWithValue("@ContactInfo", e_posta);
            ureticiListe.Parameters.AddWithValue("@ManifPass", sifre);

            object ManufacturerID = ureticiListe.ExecuteScalar();
            if (ManufacturerID != null)
            {
                label3.Text = ManufacturerID.ToString();
            }
            else
            {
                MessageBox.Show("Üretici bulunamadı.");
            }

            SqlCommand ilacListe = new SqlCommand(
     "SELECT * FROM Drugs WHERE DrugID = @DrugID",
     sqlOperations.conn);
            ilacListe.Parameters.AddWithValue("@DrugID", ManufacturerID.ToString());
            SqlDataAdapter da = new SqlDataAdapter(ilacListe);
            DataTable table = new DataTable();
            da.Fill(table);
            urtcrctgrntgrd.DataSource = table;


            ilacEkleSil ilacekleForm = new ilacEkleSil();
            ilacekleForm.ShowDialog();
        }
    }
}
