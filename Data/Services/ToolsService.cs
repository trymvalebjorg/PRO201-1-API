using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using bright_web_api.Data.ViewModels;

namespace bright_web_api.Data.Services
{
    public class ToolsService
    {

        private AppDbContext _context;
        public ToolsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddTool(ToolVM tool)
        {
            var _tool = new Tool()
            {
                Name = tool.Name,
                Image = tool.Image
            };

            _context.Tools.Add(_tool);
            _context.SaveChanges();
        }

        public List<Tool> GetAllTools() => _context.Tools.ToList();

        public Tool GetToolById(int toolId) => _context.Tools.FirstOrDefault(n => n.Id == toolId);


    }
}
