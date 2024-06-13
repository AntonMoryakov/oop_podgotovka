using Microsoft.AspNetCore.Mvc;

namespace exzoop19back.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/ObjectModels")]
    public class ObjectModelsController : ControllerBase
    {
        private List<ObjectModel> _objectModels = new List<ObjectModel>()
    {
        new ObjectModel { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
        new ObjectModel { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" },
        new ObjectModel { Id = 3, Name = "Bob Johnson", Email = "bob.johnson@example.com" }
    };

        [HttpGet("GetAllObjectModels")]
        public IActionResult GetAllObjectModels()
        {
            return Ok(_objectModels);
        }

        public class ObjectModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}