using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandomNumber.Services;

namespace RandomNumber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomNumberController : ControllerBase
    {
        private readonly IRandomService _randomNumberService1;
        private readonly IRandomService _randomNumberService2;
        public RandomNumberController(IRandomService randomNumberService1,IRandomService randomNumberService2)
        {
            _randomNumberService1 = randomNumberService1;
            _randomNumberService2 = randomNumberService2;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                N1 = _randomNumberService1.GetNumber(),
                N2 = _randomNumberService2.GetNumber()
            });
        }
    }
}
