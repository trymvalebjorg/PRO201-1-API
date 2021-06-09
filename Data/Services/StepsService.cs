using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using bright_web_api.Data.ViewModels;

namespace bright_web_api.Data.Services
{
    public class StepsService
    {

        private AppDbContext _context;
        public StepsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddStep(StepVM step)
        {
            var _step = new Step()
            {
                Title = step.Title,
                Description = step.Description,
                Image = step.Image,
                Video = step.Video,
                RepairId = step.RepairId
            };

            _context.Steps.Add(_step);
            _context.SaveChanges();
        }

        public List<StepVM> GetAllSteps()
        {
            var _steps = _context.Steps.Select(step => new StepVM()
            {
                Id = step.Id,
                Title = step.Title,
                Description = step.Description,
                Image = step.Image,
                Video = step.Video,
                RepairId = step.RepairId
            }).ToList();

            return _steps;
        }

        public List<StepWithoutRepairIdVM> GetStepsByRepairId(int repairId) => _context.Steps.Where(n => n.RepairId == repairId).Select(step => new StepWithoutRepairIdVM()
        {
            Id = step.Id,
            Title = step.Title,
            Description = step.Description,
            Image = step.Image,
            Video = step.Video,
        }).ToList();

        public StepWithRepairVM GetStepById(int stepId)
        {
            var _step = _context.Steps.Where(n => n.Id == stepId).Select(step => new StepWithRepairVM()
            {
                Id = step.Id,
                Title = step.Title,
                Description = step.Description,
                Image = step.Image,
                Video = step.Video,
                Repair = step.Repair.Title
            }).FirstOrDefault();

            return _step;
        }

        public StepWithRepairVM GetFirstStep()
        {
            var _step = _context.Steps.Select(step => new StepWithRepairVM()
            {
                Id = step.Id,
                Title = step.Title,
                Description = step.Description,
                Image = step.Image,
                Video = step.Video,
                Repair = step.Repair.Title
            }).FirstOrDefault();

            return _step;

        }
    }
}
