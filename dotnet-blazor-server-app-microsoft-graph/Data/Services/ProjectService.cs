using Microsoft.EntityFrameworkCore;
using ProductiGraph.Data.Models;

namespace ProductiGraph.Data.Services
{
    public class ProjectService
    {
        private GraphassDbContext _dbContext;

        public ProjectService(GraphassDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _dbContext.Project.ToListAsync();
        }

        public async Task<Project> AddProjectAsync(Project project)
        {
            try
            {
                _dbContext.Project.Add(project);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return project;
        }

        public async Task<Project> UpdateProjectAsync(Project project)
        {
            try
            {
                var oldProject = _dbContext.Project.FirstOrDefault(p => p.Id == project.Id);
                if (oldProject != null)
                {
                    _dbContext.Project.Update(project);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return project;
        }

        public async Task DeleteProjectAsync(Project project)
        {
            try
            {
                _dbContext.Project.Remove(project);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
