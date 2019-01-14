using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;

namespace TotalSynergy.Services.Abstracts
{
    public interface IContactService
    {
        IQueryable<Contact> GetContacts();
        Contact GetContact(int Id);
        void InsertContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
        
    }
}
