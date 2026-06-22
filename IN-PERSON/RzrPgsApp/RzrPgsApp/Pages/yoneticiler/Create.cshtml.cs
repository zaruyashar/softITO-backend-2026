using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace RzrPgsApp.Pages.yoneticiler
{
    public class CreateModel : PageModel
    {
        public yoneticiler yoneticibilgi = new yoneticiler();

        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            yoneticibilgi.AdSoyad = Request.Form["AdSoyad"];
            yoneticibilgi.Email = Request.Form["Email"];
            yoneticibilgi.Telefon = Request.Form["Telefon"];
            yoneticibilgi.Adres = Request.Form["Adres"];
            yoneticibilgi.Giris = Request.Form["Giris"];

            if (yoneticibilgi.AdSoyad.Length == 0 || yoneticibilgi.Email.Length == 0 || yoneticibilgi.Telefon.Length == 0 || yoneticibilgi.Adres.Length == 0 || yoneticibilgi.Giris.Length == 0)
            {
                errorMessage = "Tüm alanların doldurulması zorunludur.";
                return;
            }

            try
            {
                string conString = "Server=(localdb)\\MSSQLLocalDB; Database = Northwind; Integrated Security = True; TrustServerCertificate = True;";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string sql = "INSERT INTO yoneticiler(Adsoyad, Email, Telefon, Adres, Giris) VALUES(@Adsoyad, @Email, @Telefon, @Adres, @Giris)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Adsoyad", yoneticibilgi.AdSoyad);
                        command.Parameters.AddWithValue("@Email", yoneticibilgi.Email);
                        command.Parameters.AddWithValue("@Telefon", yoneticibilgi.Telefon);
                        command.Parameters.AddWithValue("@Adres", yoneticibilgi.Adres);
                        command.Parameters.AddWithValue("@Giris", yoneticibilgi.Giris);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            successMessage = "Kayıt başarılı!";
            Response.Redirect("/yoneticiler/Index");
        }
    }
}
