using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.Models
{
    public class Report_RepairedPart
    {
        public int Id { get; set; }

        //Navigation properties
        public int ReportId { get; set; }
        public Report Report { get; set; }

        public int RepairedPartId { get; set; }
        public RepairedPart RepairedPart { get; set; }

    }
}
