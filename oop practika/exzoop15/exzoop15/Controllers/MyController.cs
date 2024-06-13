using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace exzoop15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly MyManager _manager;

        public MyController(MyManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public IActionResult Post([FromBody] MyDataModel data)
        {
            _manager.ProcessData(data);
            return Ok();
        }
    }

}
