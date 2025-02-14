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
    public partial class DoktorReceteGuncelle : Form
    {
        private int prescriptionID;  // PrescriptionID'yi tutacak alan
        private string hastaAdi;

        // Parametreli constructor ekleyelim
        public DoktorReceteGuncelle(int prescriptionID, string hastaAdi)
        {
            InitializeComponent();
            this.prescriptionID = prescriptionID;  // prescriptionID'yi alıyoruz
            this.hastaAdi = hastaAdi;
        }
        private void DoktorReceteGuncelle_Load_1(object sender, EventArgs e)
        {

            lblHastaAdi.Text = $"{hastaAdi} adlı hastanın reçetesini güncellemektesiniz.";
            // Seçilen reçeteyi getir
            receteGetir();

            // Doktorları ComboBox'a yükleyelim
            SqlCommand doktorListele = new SqlCommand("SELECT DoctorID, FirstName + ' ' + LastName AS DoctorName FROM Doctors", sqlOperations.conn);
            SqlDataAdapter doktorAdapter = new SqlDataAdapter(doktorListele);
            DataTable doktorTable = new DataTable();
            doktorAdapter.Fill(doktorTable);

            comboBoxDoctor.DisplayMember = "DoctorName"; // Görünen değer
            comboBoxDoctor.ValueMember = "DoctorID";      // Arka planda tutulan değer
            comboBoxDoctor.DataSource = doktorTable;


            // İlaçları ComboBox'a yükleyelim
            SqlCommand ilacListele = new SqlCommand("SELECT DrugID, DrugName FROM Drugs", sqlOperations.conn);
            SqlDataAdapter ilacAdapter = new SqlDataAdapter(ilacListele);
            DataTable ilacTable = new DataTable();
            ilacAdapter.Fill(ilacTable);

            comboBoxIlac.DisplayMember = "DrugName";  // Görünen değer
            comboBoxIlac.ValueMember = "DrugID";      // Arka planda tutulan değer
            comboBoxIlac.DataSource = ilacTable;
        }

        private void receteGetir()
        {
            try
            {
                // PrescriptionID'ye göre reçeteyi getirme
                SqlCommand secilenReceteKomut = new SqlCommand("SELECT * FROM Prescriptions WHERE PrescriptionID = @PrescriptionID", sqlOperations.conn);
                secilenReceteKomut.Parameters.AddWithValue("@PrescriptionID", prescriptionID);
                sqlOperations.checkConn(sqlOperations.conn);

                SqlDataAdapter da = new SqlDataAdapter(secilenReceteKomut);
                DataTable table = new DataTable();
                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    // Reçeteyi form elemanlarına yükleyelim
                    DataRow row = table.Rows[0];

                    // Hasta adı değişmeyecek

                    comboBoxDoctor.SelectedValue = row["DoctorID"];
                    comboBoxIlac.SelectedValue = row["DrugID"];
                    textBoxDosage.Text = row["Dosage"].ToString();
                    textBoxFrequency.Text = row["Frequency"].ToString();
                    textBoxDuration.Text = row["Duration"].ToString();

                    // Reçeteyi DataGridView'e yükleyelim
                    DataTable receteTable = new DataTable();
                    receteTable.Columns.Add("Doctor", typeof(string));
                    receteTable.Columns.Add("Drug", typeof(string));
                    receteTable.Columns.Add("Dosage", typeof(string));
                    receteTable.Columns.Add("Frequency", typeof(string));
                    receteTable.Columns.Add("Duration", typeof(string));

                    DataRow newRow = receteTable.NewRow();
                    newRow["Doctor"] = comboBoxDoctor.Text;
                    newRow["Drug"] = comboBoxIlac.Text;
                    newRow["Dosage"] = textBoxDosage.Text;
                    newRow["Frequency"] = textBoxFrequency.Text;
                    newRow["Duration"] = textBoxDuration.Text;

                    receteTable.Rows.Add(newRow);
                    receteDataGridView.DataSource = receteTable; // Yeni reçeteyi gösteriyoruz
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Reçete getirilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void receteGuncelleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("recete guncelle buton");
            try
            {
                // Güncellenmiş bilgileri al

                int doctorID = (int)comboBoxDoctor.SelectedValue;   // Doktor ID'sini al
                int drugID = (int)comboBoxIlac.SelectedValue;       // İlaç ID'sini al
                string dosage = textBoxDosage.Text;                  // Dozajı al
                string frequency = textBoxFrequency.Text;            // Frekansı al
                string duration = textBoxDuration.Text;              // Süreyi al

                // SQL Update komutunu hazırlıyoruz
                SqlCommand guncellemeKomutu = new SqlCommand("UPDATE Prescriptions SET DoctorID = @DoctorID, DrugID = @DrugID, Dosage = @Dosage, Frequency = @Frequency, Duration = @Duration WHERE PrescriptionID = @PrescriptionID", sqlOperations.conn);

                guncellemeKomutu.Parameters.AddWithValue("@DoctorID", doctorID);
                guncellemeKomutu.Parameters.AddWithValue("@DrugID", drugID);
                guncellemeKomutu.Parameters.AddWithValue("@Dosage", dosage);
                guncellemeKomutu.Parameters.AddWithValue("@Frequency", frequency);
                guncellemeKomutu.Parameters.AddWithValue("@Duration", duration);
                guncellemeKomutu.Parameters.AddWithValue("@PrescriptionID", prescriptionID);

                sqlOperations.checkConn(sqlOperations.conn);

                int rowsAffected = guncellemeKomutu.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Reçete başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Reçete güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Güncellenen reçeteyi DataGridView'e yansıt
                    receteGetir(); // Yeniden yükleyelim
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}


