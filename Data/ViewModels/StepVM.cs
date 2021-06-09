using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.ViewModels
{
    public class StepVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public int RepairId { get; set; }
    }

    public class StepWithoutRepairIdVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
    }

    public class StepWithRepairVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public string Repair { get; set; }
    }
}
