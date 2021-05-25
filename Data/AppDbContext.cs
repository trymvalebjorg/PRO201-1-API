using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bright_web_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Repair_Tool>()
                .HasOne(r => r.Repair)
                .WithMany(rt => rt.Repair_Tools)
                .HasForeignKey(ri => ri.RepairId);

            modelBuilder.Entity<Repair_Tool>()
                .HasOne(r => r.Tool)
                .WithMany(rt => rt.Repair_Tools)
                .HasForeignKey(ri => ri.ToolId);

            modelBuilder.Entity<Report_RepairedPart>()
                .HasOne(r => r.Report)
                .WithMany(rt => rt.Report_RepairedParts)
                .HasForeignKey(ri => ri.ReportId);

            modelBuilder.Entity<Report_RepairedPart>()
                .HasOne(r => r.RepairedPart)
                .WithMany(rt => rt.Report_RepairedParts)
                .HasForeignKey(ri => ri.RepairedPartId);

            modelBuilder.Entity<Report_ReplacedPart>()
                .HasOne(r => r.Report)
                .WithMany(rt => rt.Report_ReplacedParts)
                .HasForeignKey(ri => ri.ReportId);

            modelBuilder.Entity<Report_ReplacedPart>()
                .HasOne(r => r.ReplacedPart)
                .WithMany(rt => rt.Report_ReplacedParts)
                .HasForeignKey(ri => ri.ReplacedPartId);
        }

        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Repair_Tool> Repairs_Tools { get; set; }
        public DbSet<Tool> Tools { get; set; }

    }
}
