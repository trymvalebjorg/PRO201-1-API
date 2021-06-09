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
    public class RepairedPartsController : ControllerBase
    {
        private RepairedPartsService _repairedPartsService;
        public RepairedPartsController(RepairedPartsService repairedPartsService)
        {
            _repairedPartsService = repairedPartsService;
        }

        [HttpGet("get-all-parts")]
        public IActionResult GetAllParts()
        {
            var allParts = _repairedPartsService.GetAllParts();
            return Ok(allParts);
        }
    }
}