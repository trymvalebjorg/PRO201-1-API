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
                Video = step.Video
            };

            _context.Steps.Add(_step);
            _context.SaveChanges();
        }

        public List<Step> GetAllSteps() => _context.Steps.ToList();

        public List<StepWithoutRepairIdVM> GetStepsByRepairId(int repairId) => _context.Steps.Where(n => n.RepairId == repairId).Select(step => new StepWithoutRepairIdVM()
        {
            Title = step.Title,
            Description = step.Description,
            Image = step.Image,
            Video = step.Video,
        }).ToList();

        public Step GetStepById(int stepId) => _context.Steps.FirstOrDefault(n => n.Id == stepId);

    }
}
