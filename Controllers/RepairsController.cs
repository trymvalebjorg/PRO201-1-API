using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Services;
using bright_web_api.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bright_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairsController : ControllerBase
    {
        public RepairsService _repairsService;

        public RepairsController(RepairsService repairsService)
        {
            _repairsService = repairsService;
        }

        [HttpPost("add-repair")]
        public IActionResult AddRepair([FromBody]RepairVM repair)
        {
            _repairsService.AddRepair(repair);
            return Ok();
        }

        [HttpPut("update-repair-by-id/{id}")]
        public IActionResult UpdateRepairById(int id, [FromBody]RepairVM repair)
        {
            var _updatedRepair = _repairsService.UpdateRepairById(id, repair);
            return Ok(_updatedRepair);
        }

        [HttpDelete("delete-repair-by-id/{id}")]
        public IActionResult DeleteRepairById(int id)
        {
            _repairsService.DeleteRepairById(id);
            return Ok();
        }
 
        [HttpGet("get-all-repairs")]
        public IActionResult GetAllRepairs()
        {
            var allRepairs = _repairsService.GetAllRepairs();
            return Ok(allRepairs);
        }

        [HttpGet("get-repair-by-id/{id}")]
        public IActionResult GetRepairById(int id)
        {
            var repair = _repairsService.GetRepairById(id);
            return Ok(repair);
        }
    }
}
