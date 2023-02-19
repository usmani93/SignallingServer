using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignallingServer.Hubs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SignallingServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HubController : ControllerBase
    {
        ChatHub hub;
        public HubController(IHubContext<ChatHub> context)
        {
            hub = new ChatHub(context);
        }

        // GET: api/<HubController>
        [HttpGet("Get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HubController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HubController>
        [HttpPost("Send")]
        public void Post([FromBody] string value)
        {
            hub.NewMessage("s", "s");
        }

        // PUT api/<HubController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HubController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}