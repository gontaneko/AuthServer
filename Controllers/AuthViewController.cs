using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using System;

namespace AuthServer.Controllers
{
    [Route("[controller]")]
    public class AuthViewController : Controller
    {
        private readonly ILogger<AuthViewController> _logger;

        public AuthViewController(ILogger<AuthViewController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        } 
    }
}