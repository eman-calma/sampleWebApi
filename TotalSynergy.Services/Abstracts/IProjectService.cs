using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;

namespace TotalSynergy.Services.Abstracts
{
    public interface IProjectService
    {
        IQueryable<Project> GetProjects();
        Project GetProject(int Id);
        void InsertProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
    }
}
