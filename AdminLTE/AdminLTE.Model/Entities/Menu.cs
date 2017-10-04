using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Model.Entities
{
   public class Menu:BaseEntity
    {
        public Guid MenuCode { get; set; }
        public Guid? ParentMenuCode { get; set; }
        public string Url { get; set; }

        public string Name { get; set; }

        public bool? IsLeaf { get; set; }

        public bool? IsAutoExpand { get; set; }

        public string IconName { get; set; }

        public string ParentName { get; set; }

        public string SortNo { get; set; }
    }
}
