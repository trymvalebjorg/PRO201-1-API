using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;

namespace bright_web_api.Data.ViewModels
{
    public class ProductVM
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Report> Reports { get; set; }
    }
}
