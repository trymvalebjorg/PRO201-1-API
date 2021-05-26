using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bright_web_api.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Report> Reports { get; set; }
        public List<Repair> Repairs { get; set; }
    }
}
