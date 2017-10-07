using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Core.Data;

namespace AdminLTE.DAL.User
{
    public class UserService:BaseService<Model.Entities.User>
    {
        /// <summary>
        /// 得到用户
        /// </summary>
        /// <param name="predicate">委托</param>
        /// <returns></returns>
        public Model.Entities.User GetUser(Expression<Func<Model.Entities.User
            , bool>> predicate)
        {
            return GetEntity(predicate);
        }
    }
}
