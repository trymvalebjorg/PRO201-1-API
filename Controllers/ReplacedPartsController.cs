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
    public class ReplacedPartsController : ControllerBase
    {
        private ReplacedPartsService _replacedPartsService;
        public ReplacedPartsController(ReplacedPartsService replacedPartsService)
        {
            _replacedPartsService = replacedPartsService;
        }

        [HttpGet("get-all-parts")]
        public IActionResult GetAllParts()
        {
            var allParts = _replacedPartsService.GetAllParts();
            return Ok(allParts);
        }
    }
}
