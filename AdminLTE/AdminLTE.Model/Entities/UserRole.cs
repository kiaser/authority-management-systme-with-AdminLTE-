using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Model.Entities
{
   public class UserRole:BaseEntity
    {
        public int UserId { get; set; }

        public int  RoleId { get; set; }


        [ForeignKey("UserId")]
        public virtual  User User { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
