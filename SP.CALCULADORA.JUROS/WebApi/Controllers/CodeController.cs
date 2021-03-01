using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class CodeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "https://github.com/Douuuglas/sp-calculadora-juros-api";
        }
    }
}
