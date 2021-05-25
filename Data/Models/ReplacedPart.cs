using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.Models
{
    public class ReplacedPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        //Navigation properties
        public List<Report_ReplacedPart> Report_ReplacedParts { get; set; }
    }
}
