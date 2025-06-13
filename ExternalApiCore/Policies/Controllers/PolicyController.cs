using Microsoft.AspNetCore.Mvc;
using ExternalApiCore.Policies.DTOs;

namespace ExternalApiCore.Policies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        // GET: api/<PolicyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PolicyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PolicyController>
        [HttpPost("validate")]
        public async Task<ActionResult<ValidationResultDto>> ValidatePolicy(int policyId)
        {
            var rnd = new Random();
            var result = new ValidationResultDto
            {
                IsValid = rnd.Next(0, 100) > 20, // 80% de probabilidad de éxito
                ValidationCode = $"VAL-{DateTime.UtcNow.Ticks}",
                Message = "Validation processed successfully"
            };

            return Ok(result);
        }

        // PUT api/<PolicyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PolicyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
