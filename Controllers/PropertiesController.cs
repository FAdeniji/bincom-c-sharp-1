using Ebele;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Bincom_MVC_App.Controllers
{
    public class PropertiesController : Controller
    {
        public List<Property> properties = new List<Property>()
        {
            new Property() { Id = 1, DateAdded = DateTime.Now, IsAvailable = true, Name = "Property 1" },
            new Property() { Id = 2, DateAdded = DateTime.Now, IsAvailable = true, Name = "Property 2" },
            new Property() { Id = 3, DateAdded = DateTime.Now, IsAvailable = true, Name = "Property 3" },
        };

        public IActionResult Index()
        {
            // ViewBag["properties"] = JsonConvert.SerializeObject(properties);

            return View(properties);
        }

        // Example method to get properties; replace this with your data fetching logic
        private List<Property> GetProperties()
        {
            return properties;
        }        

        public IActionResult FetchSingleProperty(int id)
        {
            return View();
        }
    }
}
