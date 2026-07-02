using CachingQrApp.Models;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Diagnostics;

namespace CachingQrApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Karekod()
        {
            string hedefWebsitesi = "https://google.com";
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData rCodeData = qrGenerator.CreateQrCode(hedefWebsitesi, QRCodeGenerator.ECCLevel.Q))
                {

                    using (PngByteQRCode qrCode = new PngByteQRCode(rCodeData))
                    {
                        byte[] qrCodeBytes = qrCode.GetGraphic(20);
                        string base64Gorsel = Convert.ToBase64String(qrCodeBytes);

                        ViewBag.KareKodGorseli = $"data:image/png;base64,{base64Gorsel}";
                    }


                }
            }


            return View();
        }
    }
}
