using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using bright_web_api.Data.ViewModels;

namespace bright_web_api.Data.Services
{
    public class RepairsService
    {
        private AppDbContext _context;
        public RepairsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddRepair(RepairVM repair)
        {
            var _repair = new Repair()
            {
                Title = repair.Title,
                Description = repair.Description,
                Image = repair.Image,
                Difficulty = repair.Difficulty,
                Time = repair.Time,
                Pdf = repair.Pdf
            };

            _context.Repairs.Add(_repair);
            _context.SaveChanges(); 
        }

        public List<Repair> GetAllRepairs() => _context.Repairs.ToList();

        public RepairWithStepsAndToolsVM GetRepairById(int repairId)
        {
            var _repairWithStepsAndTools = _context.Repairs.Where(n => n.Id == repairId).Select(repair => new RepairWithStepsAndToolsVM()
            {
                Title = repair.Title,
                Description = repair.Description,
                Image = repair.Image,
                Difficulty = repair.Difficulty,
                Time = repair.Time,
                Pdf = repair.Pdf,
                Tools = repair.Repair_Tools.Select(n => n.Tool.Name).ToList(),
                Steps = repair.Steps.Select(n => n.Id).ToList(),
            }).FirstOrDefault();

            return _repairWithStepsAndTools;
        }

        public Repair UpdateRepairById(int repairId, RepairVM repair)
        {
            var _repair = _context.Repairs.FirstOrDefault(n => n.Id == repairId);
            if(_repair != null)
            {
                _repair.Title = repair.Title;
                _repair.Description = repair.Description;
                _repair.Image = repair.Image;
                _repair.Difficulty = repair.Difficulty;
                _repair.Time = repair.Time;
                _repair.Pdf = repair.Pdf;

                _context.SaveChanges(); 
            }

            return _repair;
        }

        public void DeleteRepairById(int repairId)
        {
            var _repair = _context.Repairs.FirstOrDefault(n => n.Id == repairId);
            if(_repair != null)
            {
                _context.Repairs.Remove(_repair);
                _context.SaveChanges();
            }
        }

    }
}
