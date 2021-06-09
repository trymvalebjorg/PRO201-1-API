using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using bright_web_api.Data.ViewModels;

namespace bright_web_api.Data.Services
{
    public class ReplacedPartsService
    {

        private AppDbContext _context;
        public ReplacedPartsService(AppDbContext context)
        {
            _context = context;
        }

        public List<ReplacedPartVM> GetAllParts()
        {
            var _parts = _context.ReplacedParts.Select(part => new ReplacedPartVM()
            {
                Id = part.Id,
                Name = part.Name,
                Image = part.Image,
            }).ToList();

            return _parts;
        }

    }
}
