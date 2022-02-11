using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModelsLibrary;
using WordOfTheDay.AnaliticsMicroservice.Domain;

namespace WordOfTheDay.AnaliticsMicroservice.Api.Controllers
{
    [Route("api/analitics")]
    [ApiController]
    public class AnaliticsController : ControllerBase
    {
        private readonly IAnaliticsServices _analiticsServices;
        public AnaliticsController(IAnaliticsServices analiticsServices)
        {
            _analiticsServices = analiticsServices;
        }
        [HttpGet("get-all-info")]
        public async Task<IActionResult> GetAllInfo()
        {
            var allInfo = await _analiticsServices.AllInfo();

            return Ok(allInfo);
        }
    }
}
