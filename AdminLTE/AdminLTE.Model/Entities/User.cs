using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Model.Entities
{
    public class User : BaseEntity
    {
        public string LoginName { get; set; }

        public string PassWord { get; set; }
    }
}
