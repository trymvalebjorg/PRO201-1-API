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
    public class ToolsController : ControllerBase
    {
        private ToolsService _toolsService;
        public ToolsController(ToolsService toolsService)
        {
            _toolsService = toolsService;
        }

        [HttpGet("get-all-tools")]
        public IActionResult GetAllTools()
        {
            var allTools = _toolsService.GetAllTools();
            return Ok(allTools);
        }

        [HttpGet("get-tool-by-id/{id}")]
        public IActionResult GetToolById(int id)
        {
            var tool = _toolsService.GetToolById(id);
            return Ok(tool);
        }

        [HttpPost("add-tool")]
        public IActionResult AddTool([FromBody] ToolVM tool)
        {
            _toolsService.AddTool(tool);
            return Ok();
        }
    }
}
