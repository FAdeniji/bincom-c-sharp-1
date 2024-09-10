using Bincom_MVC_App.Data;
using Ebele;
using Microsoft.AspNetCore.Mvc;

namespace Bincom_MVC_App.Controllers
{
    public class PropertiesController : Controller
    {
        public readonly BincomContext _dbConn;

        public PropertiesController(BincomContext dbConn)
        {
            _dbConn = dbConn;
        }

        public IActionResult Index()
        {
            var properties = _dbConn.Properties.ToList(); 
            return View(properties);
        }

        [HttpPost]
        public async Task<IActionResult> SingleProperty(int propertyId)
        {
            // fetch property from list of properties
            var singleProperty = _dbConn.Properties
                .Where(p => p.Id == propertyId)
                .FirstOrDefault();

            // return the property as a model in the view
            return View(singleProperty);
        }

        // Return Take Home After Tax#
        //private double ReturnTakeHomeAfterTax(double salary) => salary - 5000;
        private double ReturnTakeHomeAfterTax(double salary)
        {
            return salary - 5000;
        }

        private double ReturnTakeHomeAfterTax(int salary)
        {
            return salary - 5000;
        }

        private double ReturnTakeHomeAfterTax(float salary)
        {
            return salary - 5000;
        }
    }
}
