using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.Models
{
    public class Repair_Tool
    {
        public int Id { get; set; }

        //Navigation properties
        public int RepairId { get; set; }
        public Repair Repair { get; set; }

        public int ToolId { get; set; }
        public Tool Tool { get; set; }

    }
}
