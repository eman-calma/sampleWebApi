using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;

namespace TotalSynergy.Services.Abstracts
{
    public interface IProjectContactService
    {
        IQueryable<ProjectContact> GetProjectContacts();
        ProjectContact GetProjectContact(int Id);
        void InsertProjectContact(ProjectContact projectContact);
        void UpdateProjectContact(ProjectContact projectContact);
        void DeleteProjectContact(ProjectContact projectContact);
        IQueryable<Contact> GetContactByProject(int id);
    }
}
