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
    public class ContactService : IContactService
    {
        private IRepository<Contact> _contactRepo;

        public ContactService(IRepository<Contact> contactRepo)
        {
            this._contactRepo = contactRepo;
        }

        public IQueryable<Contact> GetContacts()
        {
            return _contactRepo.Table;
        }

        public Contact GetContact(int id)
        {
            return _contactRepo.GetById(id);
        }

        public void InsertContact(Contact contact)
        {
            _contactRepo.Insert(contact);
        }

        public void UpdateContact(Contact contact)
        {
            _contactRepo.Update(contact);
        }

        public void DeleteContact(Contact contact)
        {
            _contactRepo.Delete(contact);
        }

        
    }
}
