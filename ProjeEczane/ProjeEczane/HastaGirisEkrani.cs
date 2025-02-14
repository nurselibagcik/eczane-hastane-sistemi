using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjeEczane
{
    public partial class HastaGirisEkrani : Form
    {
        public HastaGirisEkrani()
        {
            InitializeComponent();
        }

        private void receteGoruntuBtn_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgiler
            string hastaAdi = hastaAdtextBox.Text.Trim();
            string hastaSoyadi = hastaSoyadtextBox.Text.Trim();
            string hastaNo = hastaNotextBox.Text.Trim();

            try
            {
                // Bağlantıyı kontrol et
                sqlOperations.checkConn(sqlOperations.conn);

                // Hasta bilgileri ile PatientID alma sorgusu
                SqlCommand hastaListe = new SqlCommand("SELECT PatientID FROM Patients WHERE FirstName = @FirstName AND LastName = @LastName AND ContactInfo = @ContactInfo",
                    sqlOperations.conn);

                hastaListe.Parameters.AddWithValue("@FirstName", hastaAdi);
                hastaListe.Parameters.AddWithValue("@LastName", hastaSoyadi);
                hastaListe.Parameters.AddWithValue("@ContactInfo", hastaNo);

                object patientID = hastaListe.ExecuteScalar();

                if (patientID != null)
                {
                    kimlik.Text = patientID.ToString(); // Hasta ID'yi UI'da göster

                    // Reçete bilgilerini çekmek için sorgu
                    SqlCommand receteListe = new SqlCommand("SELECT * FROM Prescriptions WHERE PatientID = @PatientID",
                        sqlOperations.conn);

                    receteListe.Parameters.AddWithValue("@PatientID", patientID);

                    SqlDataAdapter da = new SqlDataAdapter(receteListe);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    hastaReceteGrid.AutoGenerateColumns = true;

                    // DataGridView'e sonuçları bağla
                    hastaReceteGrid.DataSource = table;
                }

                else
                {
                    // Hasta bulunamadı
                    MessageBox.Show("Girilen bilgilerle eşleşen bir hasta bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
