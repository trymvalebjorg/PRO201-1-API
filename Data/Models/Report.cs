using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.Models
{
    public class Report
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        //Navigation properties
        public List<Report_RepairedPart> Report_RepairedParts { get; set; }
        public List<Report_ReplacedPart> Report_ReplacedParts { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
