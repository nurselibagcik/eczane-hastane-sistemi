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
    public partial class DoktorGirisEkrani : Form
    {
        public DoktorGirisEkrani()
        {
            InitializeComponent();
            // Form yüklendiğinde butonlar devre dışı
            hstgrntbtn.Visible = false;
            yenihastabtn.Visible = false;
            guncellebtn.Visible = false;
            silbtn.Visible = false;
            secileniSilBtn.Visible = false;
            secileniGuncelleBtn.Visible = false;

            // Giriş butonu olayını bağla
            doktorgrsbtn.Click += new EventHandler(doktorgrsbtn_Click);
        }

        private void doktorgrsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Doktor giriş bilgilerini alıyoruz
                string doktorAdi = textBoxad.Text;
                string doktorPass = textBoxpass.Text;

                // Veritabanı bağlantısını kontrol et
                sqlOperations.checkConn(sqlOperations.conn);

                // Doktor adı ve şifre doğrulama
                SqlCommand doktorListe = new SqlCommand(
                    "SELECT DoctorID FROM Doctors WHERE FirstName = @FirstName AND DoctorPass = @DoctorPass",
                    sqlOperations.conn);

                doktorListe.Parameters.AddWithValue("@FirstName", doktorAdi);
                doktorListe.Parameters.AddWithValue("@DoctorPass", doktorPass);

                object doctorID = doktorListe.ExecuteScalar();

                if (doctorID != null)
                {
                    // Giriş başarılı
                    MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Butonları etkinleştir
                    hstgrntbtn.Visible = true;
                    yenihastabtn.Visible = true;
                    guncellebtn.Visible = true;
                    silbtn.Visible = true;

                    // Giriş bilgilerini sıfırlama
                    textBoxad.Clear();
                    textBoxpass.Clear();
                }
                else
                {
                    // Giriş başarısız
                    MessageBox.Show("Bilgiler yanlış! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Giriş bilgilerini sıfırlama
                    textBoxad.Clear();
                    textBoxpass.Clear();
                    textBoxad.Focus();
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hstgrntbtn_Click(object sender, EventArgs e)
        {
            // Hasta görüntüleme kodu
            SqlCommand hastaListe = new SqlCommand("SELECT * FROM Patients", sqlOperations.conn);

            SqlDataAdapter da = new SqlDataAdapter(hastaListe);
            DataTable table = new DataTable();
            da.Fill(table);
            dktrctgrd.DataSource = table;
        }

        private void yenihastabtn_Click(object sender, EventArgs e)
        {
            HastaEklemeForm hastaEklemeForm = new HastaEklemeForm();
            hastaEklemeForm.ShowDialog();

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Reçeteleri güncelleme için listele
                receteYenile();

                // Reçete seçilirse "Seçilen Satırı Sil" butonunu aktif et
                secileniGuncelleBtn.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Reçeteler listelenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void secileniGuncelleBtn_Click(object sender, EventArgs e)
        {
            if (dktrctgrd.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki PrescriptionID'yi al
                var prescriptionID = dktrctgrd.SelectedRows[0].Cells["PrescriptionID"].Value;
                var patientID = dktrctgrd.SelectedRows[0].Cells["PatientID"].Value;


                if (prescriptionID != null && patientID != null)
                {
                    string patientName = HastaAdiniGetir((int)patientID);
                    if (!string.IsNullOrEmpty(patientName))
                    {
                        DoktorReceteGuncelle doktorReceteGuncelleForm = new DoktorReceteGuncelle((int)prescriptionID, patientName);
                        doktorReceteGuncelleForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Hasta adı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen reçetede gecerli bilgiler bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir reçete seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string HastaAdiniGetir(int patientID)
        {
            string patientName = string.Empty; sqlOperations.checkConn(sqlOperations.conn);
            SqlCommand hastaAdiGetir = new SqlCommand("SELECT FirstName +' ' + LastName AS PatientName FROM Patients WHERE PatientID = @PatientID", sqlOperations.conn);
            hastaAdiGetir.Parameters.AddWithValue("@PatientID", patientID);
            sqlOperations.checkConn(sqlOperations.conn);

            object sonuc = hastaAdiGetir.ExecuteScalar();
            if (sonuc != null)
            {
                patientName = sonuc.ToString();
            }
            return patientName;
        }


        private void receteYenile()
        {
            try
            {
                //veritabanından tüm recetelrei alma
                SqlCommand receteListe = new SqlCommand("SELECT * FROM Prescriptions", sqlOperations.conn);

                //verileri alma
                SqlDataAdapter da = new SqlDataAdapter(receteListe);
                DataTable table = new DataTable();
                da.Fill(table);

                dktrctgrd.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Reçeteler Listelenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//receteyenıle fonk

        private void silbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Reçeteleri listele
                receteYenile();

                // "Seçilen Satırı Sil" butonunu görünür hale getir
                secileniSilBtn.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Reçeteler listelenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void secileniSilBtn_Click(object sender, EventArgs e)
        {
            if (dktrctgrd.SelectedRows.Count > 0)
            {
                secileniSilBtn.Visible = true;
                sqlOperations.checkConn(sqlOperations.conn);

                // Seçilen her satır için silme işlemi yap
                for (int i = 0; i < dktrctgrd.SelectedRows.Count; i++)
                {
                    // datagrid'den PrescriptionID'yi alma
                    var prescriptionID = dktrctgrd.SelectedRows[i].Cells["PrescriptionID"].Value;
                    //seçilen satır varsa
                    if (prescriptionID != null)
                    {
                        // silme komutu
                        SqlCommand receteSil = new SqlCommand(
                            "DELETE FROM Prescriptions WHERE PrescriptionID = @PrescriptionID",
                            sqlOperations.conn
                        );
                        receteSil.Parameters.AddWithValue("@PrescriptionID", prescriptionID);

                        // Silme komutunu çalıştırma
                        int secilenSatir = receteSil.ExecuteNonQuery();

                        if (secilenSatir > 0)
                        {
                            MessageBox.Show($"{prescriptionID} numaralı reçete başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"{prescriptionID} numaralı reçete silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seçilen satırdaki PrescriptionID boş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Güncellenmiş listeyi yükleme 
                receteYenile();
            }
            else
            {
                MessageBox.Show("Hiçbir satır seçilmedi!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}

