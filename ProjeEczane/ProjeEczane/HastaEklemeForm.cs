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
    public partial class HastaEklemeForm : Form
    {
        public HastaEklemeForm()
        {
            InitializeComponent();
        }
        private void HastaEklemeForm_Load(object sender, EventArgs e)
        {

        }

        private void hastaKaydetBtn_Click(object sender, EventArgs e)
        {
            //değişkenleri alma
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            DateTime dogumTarihi = dateTimePickerDogumTarih.Value;
            string cinsiyet = radioBtnKadin.Checked ? "Kadin" : (radioBtnErkek.Checked ? "Erkek" : null);
            string iletisimNo = maskedTextTelNo.Text;
            string hastalikGecmis = textBoxHastalikGecmis.Text;
            string identityNumber  = identityNumberTextBox.Text;

            //veritabanına kaydetme
            SqlCommand hastaEkleme = new SqlCommand("INSERT INTO Patients " +
                "(FirstName, LastName, DateOfBirth, Gender, ContactInfo, MedicalHistory,IdentityNumber)"
               + "VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @ContactInfo, @MedicalHistory, @IdentityNumber)",
               sqlOperations.conn);

            //degerleri eşleştirme
            hastaEkleme.Parameters.AddWithValue("@FirstName", ad);
            hastaEkleme.Parameters.AddWithValue("@LastName", soyad);
            hastaEkleme.Parameters.AddWithValue("@DateOfBirth", dogumTarihi);
            hastaEkleme.Parameters.AddWithValue("@Gender", cinsiyet);
            hastaEkleme.Parameters.AddWithValue("@ContactInfo", iletisimNo);
            hastaEkleme.Parameters.AddWithValue("@MedicalHistory", hastalikGecmis);
            hastaEkleme.Parameters.AddWithValue("@IdentityNumber", identityNumber);

            sqlOperations.checkConn(sqlOperations.conn);

            int eklenenKisi = hastaEkleme.ExecuteNonQuery();
            if (eklenenKisi > 0)
            {
                MessageBox.Show("Yeni Hasta Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hasta Eklenemedi, Lütfen Tekrar Deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
    }

