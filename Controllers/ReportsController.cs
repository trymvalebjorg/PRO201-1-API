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
    public class ReportsController : ControllerBase
    {
        public ReportsService _reportsService;

        public ReportsController(ReportsService reportsService)
        {
            _reportsService = reportsService;
        }

        [HttpGet("get-all-reports")]
        public IActionResult GetAllReports()
        {
            var allReports = _reportsService.GetAllReports();
            return Ok(allReports);
        }


        [HttpPost("add-report")]
        public IActionResult AddReport([FromBody]ReportVM report)
        {
            _reportsService.AddReport(report);
            return Ok();
        }
    }
}