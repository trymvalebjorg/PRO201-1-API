using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.Models
{
    public class Report_ReplacedPart
    {
        public int Id { get; set; }

        //Navigation properties
        public int ReportId { get; set; }
        public Report Report { get; set; }

        public int ReplacedPartId { get; set; }
        public ReplacedPart ReplacedPart { get; set; }

    }
}
