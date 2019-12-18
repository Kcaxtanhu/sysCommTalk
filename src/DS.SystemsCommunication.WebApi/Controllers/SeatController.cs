using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DS.SystemsCommunication.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeatController : ControllerBase
    {
        private readonly ILogger<SeatController> _logger;

        public SeatController(ILogger<SeatController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get()
        {
            return 1;
        }
    }
}
