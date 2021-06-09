using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using bright_web_api.Data.ViewModels;

namespace bright_web_api.Data.Services
{
    public class ReportsService
    {
        private AppDbContext _context;
        public ReportsService(AppDbContext context)
        {
            _context = context;
        }

        public List<ReportShortVM> GetAllReports()
        {
            var _report = _context.Reports.Select(report => new ReportShortVM()
            {
                UserId = report.UserId,
                ProductId = report.ProductId,
                RepairedPartIds = report.Report_RepairedParts.Select(n => n.Id).ToList(),
                ReplacedPartIds = report.Report_ReplacedParts.Select(n => n.Id).ToList(),
            }).ToList();

            return _report;
        }

        public void AddReport(ReportVM report)
        {
            var _report = new Report()
            {
                UserId = report.UserId,
                ProductId = report.ProductId
            };
            _context.Reports.Add(_report);
            _context.SaveChanges();

            foreach (var id in report.RepairedPartIds)
            {
                var _report_repairedPart = new Report_RepairedPart()
                {
                    ReportId = _report.Id,
                    RepairedPartId = id
                };
                _context.Reports_RepairedParts.Add(_report_repairedPart);
                _context.SaveChanges(); 
            }

            foreach (var id in report.ReplacedPartIds)
            {
                var _report_replacedPart = new Report_ReplacedPart()
                {
                    ReportId = _report.Id,
                    ReplacedPartId = id
                };
                _context.Reports_ReplacedParts.Add(_report_replacedPart);
                _context.SaveChanges();
            }
        }
    }
}
