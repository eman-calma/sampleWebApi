using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;

namespace TotalSynergy.Data.Mapping
{
    public class ProjectContactMap : EntityTypeConfiguration<ProjectContact>
    {
        public ProjectContactMap()
        {
            //key
            HasKey(t => t.Id);
            //properties
            Property(t => t.ProjectId).IsRequired();
            Property(t => t.ContactId).IsRequired();
            //table
            ToTable("ProjectContacts");
        }
    }
}
