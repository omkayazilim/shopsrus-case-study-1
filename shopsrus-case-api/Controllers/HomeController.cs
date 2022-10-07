using Microsoft.AspNetCore.Mvc;
using shopsrus.Applications;

namespace shopsrus_case_api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService; 
        public HomeController(IUserService userService)
        {
                _userService = userService; 
        }

        [HttpGet("GetUserName")]
        public Task<string> GetUserName() 
        {
            return Task.FromResult("Deneme kullanıcı");
        }
    }
}
