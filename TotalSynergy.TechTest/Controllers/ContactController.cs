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
    public class ContactController : ApiController
    {
        private IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Route("api/contacts")]
        [HttpGet]
        public IQueryable<Contact> GetContacts()
        {
            return _contactService.GetContacts();
        }

        [Route("api/contact/{id}")]
        [HttpGet]
        public Contact GetContact(int id)
        {
            return _contactService.GetContact(id);
        }

        [Route("api/contact")]
        [HttpPost]
        public bool AddContact(Contact cotact)
        {
            try
            {
                _contactService.InsertContact(cotact);
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }
}
