using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;
using TotalSynergy.Data;
using TotalSynergy.Services.Abstracts;

namespace TotalSynergy.Services
{
    public class ProjectService : IProjectService
    {
        private IRepository<Project> _projectRepo;

        public ProjectService(IRepository<Project> projectRepo)
        {
            this._projectRepo = projectRepo;
        }

        public IQueryable<Project> GetProjects()
        {
            return _projectRepo.Table;
        }

        public Project GetProject(int id)
        {
            return _projectRepo.GetById(id);
        }

        public void InsertProject(Project project)
        {
            _projectRepo.Insert(project);
        }

        public void UpdateProject(Project project)
        {
            _projectRepo.Update(project);
        }

        public void DeleteProject(Project project)
        {
            _projectRepo.Delete(project);
        }
    }
}
