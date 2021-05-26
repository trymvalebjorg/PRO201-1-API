using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.Models
{
    public class Repair
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Difficulty { get; set; }
        public int Time { get; set; }
        public string Pdf { get; set; }

        //Navigation properties
        public List<Step> Steps { get; set; }
        public List<Repair_Tool> Repair_Tools { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
