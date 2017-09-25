using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.Model.Entities.Base
{
    /// <summary>
    /// 软删除
    /// </summary>
    interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
