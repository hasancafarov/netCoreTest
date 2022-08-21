using Microsoft.AspNetCore.Mvc;
using MyApi.Services;

namespace MyApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValidNameController : Controller
    {
        private readonly IValidName _nameService;

        public ValidNameController(IValidName nameService)
        {
            _nameService = nameService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public StatusCodeResult Get(string name)
        {
            var isValidName = _nameService.isValid(name);
            if (isValidName)
                return Ok();
            else
                return BadRequest();
        }
    }
}
