using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;



namespace ProjeEczane
{
    public partial class EczaciGirisEkrani : Form
    {
        public EczaciGirisEkrani()
        {
            InitializeComponent();
          
            receteGoruntuBtn.Visible = false; // Girişten önce görünmesin
            kimlikSorgulaBtn.Visible = false;
            identityNumbertextBox.Visible = false;
            label3.Visible = false;

        }

        private int prescriptionID;

        private void girisBtn_Click(object sender, EventArgs e)
        {
            string eczaneAdi = eczaneAdtextBox.Text;
            string sifre = sifretextBox.Text;

            sqlOperations.checkConn(sqlOperations.conn);
            SqlCommand EczaciListe = new SqlCommand(
                   "SELECT PharmacyID FROM Pharmacies WHERE PharmacyName = @PharmacyName AND PharPass = @PharPass",
                   sqlOperations.conn);

            EczaciListe.Parameters.AddWithValue("@PharmacyName", eczaneAdi);
            EczaciListe.Parameters.AddWithValue("@PharPass", sifre);

            object PharmacyID = EczaciListe.ExecuteScalar();

            if (PharmacyID != null) { 
                MessageBox.Show("Giriş Başarılı","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
                receteGoruntuBtn.Visible=true;
            }
            else
            {
                MessageBox.Show("Giriş Başarısız Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void receteGoruntuBtn_Click(object sender, EventArgs e)
        {
           kimlikSorgulaBtn.Visible=true;
           identityNumbertextBox.Visible=true;
            label3.Visible = true;
        }



        private void kimlikSorgulaBtn_Click(object sender, EventArgs e)
        {
            string identityNumber = identityNumbertextBox.Text;

            try
            {
                // Hasta ve reçete bilgilerini almak için SQL komutu
                SqlCommand secilenHastaKomut = new SqlCommand(
                    @"SELECT 
                p.PatientID,  
                p.FirstName, 
                p.LastName,  
                p.DateOfBirth, 
                p.Gender, 
                p.ContactInfo, 
                p.MedicalHistory,
                p.IdentityNumber,
                pr.PrescriptionID,
                pr.DoctorID, 
                pr.DrugID, 
                pr.Dosage, 
                pr.Frequency ,  
                pr.Duration
            FROM 
                Patients p 
            INNER JOIN 
                Prescriptions pr ON p.PatientID = pr.PatientID
            WHERE 
                p.IdentityNumber = @IdentityNumber",
                    sqlOperations.conn);

                // Parametre ekleme
                secilenHastaKomut.Parameters.AddWithValue("@IdentityNumber", identityNumber);

                // Bağlantı kontrolü
                sqlOperations.checkConn(sqlOperations.conn);

                // DataAdapter ve DataTable oluşturma
                SqlDataAdapter adp = new SqlDataAdapter(secilenHastaKomut);
                DataTable dataTable = new DataTable();

                // Veriyi doldurma
                adp.Fill(dataTable);

                // Sonuç kontrolü
                if (dataTable.Rows.Count > 0)
                {
                    // DataGridView'e verileri bağlama
                    eczaneGrnDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Girilen kimlik numarasına sahip hasta bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }

}
