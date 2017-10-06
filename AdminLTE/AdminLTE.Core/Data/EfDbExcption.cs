using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.Core.Data
{
    /// <summary>
    /// 用于Entity Framework执行出错的异常。
    /// </summary>
    [Serializable]
    public class EfDbExcption : Exception
    {
        public EfDbExcption(string message) : base(message)
        {
        }

        public EfDbExcption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EfDbExcption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
