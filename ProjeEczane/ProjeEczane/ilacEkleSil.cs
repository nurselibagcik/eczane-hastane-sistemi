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
    public partial class ilacEkleSil : Form
    {
        public ilacEkleSil()
        {
            InitializeComponent();
        }
        private void eklebtn_Click(object sender, EventArgs e)
        {

            string ilacismi = ilacismibtn.Text;
            int üreticiId = Convert.ToInt32(cmbureticiId.SelectedItem);
            int ilaçtitpiId = Convert.ToInt32(ilactipiIdtextBox.Text);
            string aktifMadde = etkentextBox.Text;
            string aktifMaddeMiktar = etkenmiktartextBox.Text;
            string form = cmbForm.SelectedItem.ToString();
            DateTime onayTarihi = onaydateTimePicker.Value;

            for (int i = 0; i < cmbForm.Items.Count; i++)
            {
                var item = cmbForm.Items[i];
                Console.WriteLine(item);
            }


            SqlCommand drugTipiKontrol = new SqlCommand(
      "SELECT COUNT(*) FROM Drug_Type WHERE DrugTypeID = @DrugTypeID",
      sqlOperations.conn);
            drugTipiKontrol.Parameters.AddWithValue("@DrugTypeID", ilaçtitpiId);

            sqlOperations.checkConn(sqlOperations.conn);
            int drugTypeExists = (int)drugTipiKontrol.ExecuteScalar();

            if (drugTypeExists == 0)
            {
                // Yeni DrugType bilgilerini kullanıcıdan al
                string drugTypeName = promtSınıfı.ShowDialog("Yeni ilaç tipi adı girin:", "Yeni İlaç Tipi");
                string description = promtSınıfı.ShowDialog("Yeni ilaç tipi açıklaması girin:", "Yeni İlaç Tipi Açıklaması");

                // Yeni DrugType ekle
                SqlCommand addDrugType = new SqlCommand(
                    "INSERT INTO DrugTypes (DrugTypeID, DrugTypeName, Description) VALUES (@DrugTypeID, @DrugTypeName, @Description)",
                    sqlOperations.conn);
                addDrugType.Parameters.AddWithValue("@DrugTypeID", ilaçtitpiId);
                addDrugType.Parameters.AddWithValue("@DrugTypeName", drugTypeName);
                addDrugType.Parameters.AddWithValue("@Description", description);

                addDrugType.ExecuteNonQuery();
            }
            else
            {
                // Mevcut açıklamayı göster
                SqlCommand getDescription = new SqlCommand(
                    "SELECT Description FROM Drug_Type WHERE DrugTypeID = @DrugTypeID",
                    sqlOperations.conn);
                getDescription.Parameters.AddWithValue("@DrugTypeID", ilaçtitpiId);

                string existingDescription = (string)getDescription.ExecuteScalar();
                MessageBox.Show($"Seçilen İlaç Tipi Açıklaması: {existingDescription}");
            }

            SqlCommand ilacEkle = new SqlCommand(
       "INSERT INTO Drugs (DrugName, ManufacturerID, DrugTypeID, ActiveIngredient, Strength, Form, ApprovalDate) " +
                       "VALUES (@DrugName, @ManufacturerID, @DrugTypeID, @ActiveIngredient, @Strength, @Form, @ApprovalDate)",
       sqlOperations.conn);

            sqlOperations.checkConn(sqlOperations.conn);


            ilacEkle.Parameters.AddWithValue("@DrugName", ilacismi);
            ilacEkle.Parameters.AddWithValue("@ManufacturerID", üreticiId);
            ilacEkle.Parameters.AddWithValue("@DrugTypeID", ilaçtitpiId);
            ilacEkle.Parameters.AddWithValue("@ActiveIngredient", aktifMadde);
            ilacEkle.Parameters.AddWithValue("@Strength", aktifMaddeMiktar);
            ilacEkle.Parameters.AddWithValue("@Form", form);
            ilacEkle.Parameters.AddWithValue("@ApprovalDate", onayTarihi);


            try
            {
                int rowsAffected = ilacEkle.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("İlaç başarıyla eklendi!");
                }
                else
                {
                    MessageBox.Show("İlaç eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        public void ilaclariGoruntule()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Drugs ",
                 sqlOperations.conn);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                eklenendataGridView.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        public void goruntulebtn_Click(object sender, EventArgs e)
        {
            ilaclariGoruntule();
        }

        private void ilcKldrBtn_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili olan satırı kontrol et
            if (eklenendataGridView.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki DrugID değerini al
                int drugID = Convert.ToInt32(eklenendataGridView.SelectedRows[0].Cells["DrugID"].Value);

                // Kullanıcıdan emin olup olmadığını sor
                var result = MessageBox.Show("Bu ilacı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // İlaç silme komutunu çalıştır
                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM Drugs WHERE DrugID = @DrugID",
                            sqlOperations.conn);

                        cmd.Parameters.AddWithValue("@DrugID", drugID);

                        sqlOperations.checkConn(sqlOperations.conn); // Bağlantıyı kontrol et

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("İlaç başarıyla silindi.");
                            ilaclariGoruntule(); // Silme sonrası ilaçları tekrar görüntüle
                        }
                        else
                        {
                            MessageBox.Show("Silinecek ilaç bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir ilaç seçin.");
            }
        }

       
    }
}
