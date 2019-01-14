using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TotalSynergy.Common.Models;
using TotalSynergy.Services.Abstracts;

namespace TotalSynergy.TechTest.Controllers
{
    public class ProjectContactController : ApiController
    {
        IProjectContactService _projectContactService;
        public ProjectContactController(IProjectContactService projectContactService)
        {
            _projectContactService = projectContactService;
        }

        [Route("api/projectcontacts/{id}")]
        [HttpGet]
        public IQueryable<Contact> GetContactByProject(int id)
        {
            return _projectContactService.GetContactByProject(id);
        }
        [Route("api/projectcontact")]
        [HttpPost]
        public bool AddProjectContact(ProjectContact projectContact)
        {
            try
            {
                _projectContactService.InsertProjectContact(projectContact);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
