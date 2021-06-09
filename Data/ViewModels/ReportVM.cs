using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;

namespace bright_web_api.Data.ViewModels
{
    public class ReportVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public List<int> ReplacedPartIds { get; set; }
        public List<int> RepairedPartIds { get; set; }
    }

    public class ReportShortVM
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public List<int> ReplacedPartIds { get; set; }
        public List<int> RepairedPartIds { get; set; }
    }
}
