using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Model.Entities
{
   public class RoleMenu: BaseEntity
    {
        public int RoleId { get; set; }

        public int MenuId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("MenuId")]
        public virtual  Menu Menu { get; set; }
    }
}
