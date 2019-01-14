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
    public class ProjectContactService : IProjectContactService
    {
        private IRepository<ProjectContact> _projectContactRepo;
        private IRepository<Contact> _contactRepo;

        public ProjectContactService(IRepository<ProjectContact> projectRepo, IRepository<Contact> contactRepo)
        {
            this._projectContactRepo = projectRepo;
            this._contactRepo = contactRepo;
        }

        public IQueryable<ProjectContact> GetProjectContacts()
        {
            return _projectContactRepo.Table;
        }

        public ProjectContact GetProjectContact(int id)
        {
            return _projectContactRepo.GetById(id);
        }

        public void InsertProjectContact(ProjectContact projectContact)
        {
            _projectContactRepo.Insert(projectContact);
        }

        public void UpdateProjectContact(ProjectContact projectContact)
        {
            _projectContactRepo.Update(projectContact);
        }

        public void DeleteProjectContact(ProjectContact projectContact)
        {
            _projectContactRepo.Delete(projectContact);
        }

        public IQueryable<Contact> GetContactByProject(int id)
        {
            var contacts = _contactRepo.Table;
            var projectContactsId = _projectContactRepo.Table.Where(i => i.ProjectId == id).Select(c => c.ContactId).ToList();
            return contacts.Where(c => projectContactsId.Contains(c.Id));
        }
    }
}
