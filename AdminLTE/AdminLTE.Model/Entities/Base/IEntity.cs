using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.Model.Entities.Base
{
   public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
    
}
