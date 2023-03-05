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
                new Project { Id = 1, Name = "Build Personal Productivity Machine", Description = "I need a personal second brain to take care of my workflow efficiently", Status = "Just created", Completed = false },
                new Project { Id = 2, Name = "Mentoring with Sam", Description = "Learn about system design", Status = "Just created", Completed = false },
                new Project { Id = 3, Name = "Collab with Cayden", Description = "Thinking of making a gamified system for smart glasses", Status = "Just created", Completed = false },
                new Project { Id = 4, Name = "Research with Jina", Description = "Learn about human centered design", Status = "Just created", Completed = false },
                new Project { Id = 5, Name = "Plan Gold Engagement with Jennifer", Description = "We need to start getting UK ambassadors engaged with extra activities", Status = "Just created", Completed = false },
                new Project { Id = 6, Name = "Bring GTA UI to life", Description = "GTA is the best grinding simulator", Status = "Just created", Completed = false },
                new Project { Id = 7, Name = "Learn AI and ML", Description = "AI and ML is the future, time to pick up some skills", Status = "Just created", Completed = false },
                new Project { Id = 8, Name = "Prepare content with Baki", Description = "Get involved with the community", Status = "Just created", Completed = false },
            };
        }
        #endregion
    }
}
