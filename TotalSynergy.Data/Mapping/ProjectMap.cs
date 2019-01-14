using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;

namespace TotalSynergy.Data.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            //key
            HasKey(t => t.Id);
            //properties
            Property(t => t.Name).IsRequired();
            //table
            ToTable("Projects");
        }
    }

}
