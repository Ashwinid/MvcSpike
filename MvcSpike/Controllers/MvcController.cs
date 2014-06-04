using System.Web;
using System.Web.Mvc;
using MvcSpike.Models;
using TTL.SmartService;

namespace MvcSpike.Controllers
{
    public class MvcController : Controller
    {
        public MvcController(ISmartService smartService)
        {

        }

        // 
        // GET: /HelloWorld/ 

        public ViewResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ViewResult Welcome(string name, int numTimes = 1)
        {
            var model = new User();
            model.Name = "John";
            return View(model);
        }
    }
}