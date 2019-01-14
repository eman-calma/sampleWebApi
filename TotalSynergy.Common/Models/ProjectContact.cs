using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalSynergy.Common.Models
{
    public class ProjectContact : BaseModel
    {
        public int ProjectId { get; set; }
        public int ContactId { get; set; }
    }
}
