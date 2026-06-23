using bridge_mvc_project.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace bridge_mvc_project.Controllers
{
    public class DeveloperController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // De-serialization
            HttpClient client = new HttpClient();

            var response = client.GetAsync($"https://localhost:7071/api/Developer/GetDevelopers").Result;

            List<Developer> developers = JsonConvert.DeserializeObject<List<Developer>>(response.Content.ReadAsStringAsync().Result);

            return View(developers);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(new Developer());
        }


        [HttpPost]
        public IActionResult Create(Developer developer)
        {
            // Serialization
            HttpClient client = new HttpClient();

            StringContent content = new StringContent(JsonConvert.SerializeObject(developer), System.Text.Encoding.UTF8, "application/json");

            var response = client.PostAsync($"https://localhost:7071/api/Developer/AddDeveloper", content).Result;

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();

            var response = client.GetAsync($"https://localhost:7071/api/Developer/GetDeveloperById/{id}").Result;

            var developer = JsonConvert.DeserializeObject<Developer>(response.Content.ReadAsStringAsync().Result);

            return View(developer);
        }


        [HttpPost]
        public IActionResult Edit(Developer developer)
        {
            HttpClient client = new HttpClient();

            StringContent content = new StringContent(JsonConvert.SerializeObject(developer), System.Text.Encoding.UTF8, "application/json");

            var response = client.PutAsync($"https://localhost:7071/api/Developer/UpdateDeveloper/{developer.DeveloperId}", content).Result;

            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();

            var response = client.DeleteAsync($"https://localhost:7071/api/Developer/DeleteDeveloper/{id}").Result;

            return RedirectToAction("Index");
        }
    }
}
