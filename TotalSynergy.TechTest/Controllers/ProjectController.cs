using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TotalSynergy.Common.Models;
using TotalSynergy.Services.Abstracts;

namespace TotalSynergy.TechTest.Controllers
{
    public class ProjectController : ApiController
    {
        private IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [Route("api/projects")]
        [HttpGet]
        public IQueryable<Project> GetProjects()
        {
            return _projectService.GetProjects();
        }
        [Route("api/project/{id}")]
        [HttpGet]
        public Project GetProject(int id)
        {
            return _projectService.GetProject(id);
        }

        [Route("api/project")]
        [HttpPost]
        public bool AddProject(Project project)
        {
            try
            {
                _projectService.InsertProject(project);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
