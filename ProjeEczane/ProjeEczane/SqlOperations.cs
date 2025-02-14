using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjeEczane
{
  
        public class sqlOperations
    {
            public static SqlConnection conn = new SqlConnection("Data Source = DESKTOP-V1PFMIA\\SQLEXPRESS;Initial Catalog = ProjeTakim.bacpac; Integrated Security = True");

            public static void checkConn(SqlConnection tempConn)
            {
                try
                {
                    // Bağlantıyı kontrol et
                    if (tempConn.State == ConnectionState.Closed)
                    {
                        tempConn.Open();  // Bağlantıyı aç
                        MessageBox.Show("Bağlantı başarılı.");
                    }
                }
                catch (Exception ex)
                {
                    // Bağlantı hatası durumunda
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }

        }
    
}
