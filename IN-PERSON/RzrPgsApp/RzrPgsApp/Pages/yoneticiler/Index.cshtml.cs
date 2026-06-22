using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Data.SqlClient;

namespace RzrPgsApp.Pages.yoneticiler
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        /* yoneticiler sınıfındaki verilere tek tek attribute atamak yerine sütunlara direkt erişim istedik */

        public List<yoneticiler> listele { get; set; } = new List<yoneticiler>();

        public void OnGet()
        {
            string conString = "Server=(localdb)\\MSSQLLocalDB; Database = Northwind; Integrated Security = True; TrustServerCertificate = True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM yoneticiler";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                yoneticiler yonetici = new yoneticiler
                                {
                                    ID = reader.GetInt32(0).ToString(),
                                    AdSoyad = reader.IsDBNull(1) ? "" : reader.GetString(1),
                                    Email = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    Telefon = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                    Adres = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                    Giris = reader.IsDBNull(5) ? "" : reader.GetString(5)
                                };
                                listele.Add(yonetici);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}
