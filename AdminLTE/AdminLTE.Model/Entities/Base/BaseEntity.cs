using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.Model.Entities.Base
{
   public class BaseEntity<TPrimaryKey> : IEntity<TPrimaryKey>,ISoftDelete
    {
        [Key]
        public TPrimaryKey Id { get; set; }
        public virtual bool IsDeleted { get; set; }
    }

    public class BaseEntity:BaseEntity<int>
    { }
}
