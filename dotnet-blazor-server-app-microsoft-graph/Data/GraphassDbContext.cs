using Microsoft.EntityFrameworkCore;
using ProductiGraph.Data.Models;

namespace ProductiGraph.Data
{
    public class GraphassDbContext : DbContext
    {
        #region Contructor
        public GraphassDbContext(DbContextOptions<GraphassDbContext> options)
                : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Project> Project { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(GetProjects());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project { Id = 1, Name = "Microsoft Graph .NET hackathon", Description = "A hackathon to learn about Microsoft Graph using .NET" },
                new Project { Id = 2, Name = "Microsoft Imagine Cup", Description = "Microsoft's annual hackathon to build a solution using Microsoft Azure"},
                new Project { Id = 3, Name = "Microsoft Learn Student Ambassadors", Description = "Do cool things with Microsoft as a student"},
                new Project { Id = 4, Name = "Microsoft MVP Mentoring", Description = "Get advice about anything from a Microsoft MVP"},
                new Project { Id = 5, Name = "Social Impact Project", Description = "Build something for the Microsoft Community"}
            };
        }
        #endregion
    }
}
