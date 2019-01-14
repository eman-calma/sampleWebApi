using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;

namespace TotalSynergy.Data.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            //key
            HasKey(t => t.Id);
            //properties
            Property(t => t.FirstName).IsRequired();
            Property(t => t.LastName).IsRequired();
            Property(t => t.Address);
            Property(t => t.Phone);
            //table
            ToTable("Contacts");
        }
    }
}
