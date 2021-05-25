using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace bright_web_api.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Repairs.Any())
                {
                    context.Repairs.AddRange(new Repair()
                    {
                        Title = "A title",
                        Description = "A description",
                        Image = "http...",
                        Difficulty = 4,
                        Time = 10,
                        Pdf = "http..."
                    },
                    new Repair()
                    {
                        Title = "Another title",
                        Description = "Another description",
                        Image = "http...",
                        Difficulty = 5,
                        Time = 12,
                        Pdf = "http..."
                    });

                    context.SaveChanges(); 
                }
            }
        }
    }
}
