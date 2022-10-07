using Microsoft.AspNetCore.Mvc;
using shopsrus.Applications;

namespace shopsrus_case_api.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController()
        {
                
        }

        [HttpGet("GetUserName")]
        public Task<string> GetUserName() 
        {
            return Task.FromResult("Deneme kullanıcı");
        }
    }
}
