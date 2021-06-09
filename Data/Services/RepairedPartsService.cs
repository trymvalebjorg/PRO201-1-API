using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using bright_web_api.Data.ViewModels;

namespace bright_web_api.Data.Services
{
    public class RepairedPartsService
    {

        private AppDbContext _context;
        public RepairedPartsService(AppDbContext context)
        {
            _context = context;
        }

        public List<RepairedPartVM> GetAllParts()
        {
            var _parts = _context.RepairedParts.Select(part => new RepairedPartVM()
            {
                Id = part.Id,
                Name = part.Name,
                Image = part.Image,
            }).ToList();

            return _parts;
        }

    }
}
