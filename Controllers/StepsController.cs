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
    public class StepsController : ControllerBase
    {
        private StepsService _stepsService;
        public StepsController(StepsService stepsService)
        {
            _stepsService = stepsService;
        }

        [HttpGet("get-all-steps")]
        public IActionResult GetAllSteps()
        {
            var allSteps = _stepsService.GetAllSteps();
            return Ok(allSteps);
        }

        [HttpGet("get-step-by-id/{id}")]
        public IActionResult GetStepById(int id)
        {
            var tool = _stepsService.GetStepById(id);
            return Ok(tool);
        }

        [HttpGet("get-steps-by-repair-id/{repairId}")]
        public IActionResult GetStepsByRepairId(int repairId)
        {
            var step = _stepsService.GetStepsByRepairId(repairId);
            return Ok(step);
        }

        [HttpPost("add-step")]
        public IActionResult AddStep([FromBody] StepVM step)
        {
            _stepsService.AddStep(step);
            return Ok();
        }
    }
}
