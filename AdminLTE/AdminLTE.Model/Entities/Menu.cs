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
        public string MenuCode { get; set; }
        public string ParentMenuCode { get; set; }
        public string Url { get; set; }
    }
}
