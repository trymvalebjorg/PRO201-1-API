using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.ViewModels
{
    public class RepairVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Difficulty { get; set; }
        public int Time { get; set; }
        public string Pdf { get; set; }
    }

    public class RepairWithStepsAndToolsVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Difficulty { get; set; }
        public int Time { get; set; }
        public string Pdf { get; set; }
        public List<string> Tools { get; set; }
        public List<int> Steps { get; set; }
    }
}
