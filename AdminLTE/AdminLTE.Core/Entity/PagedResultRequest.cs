using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.Core.Entity
{
    public class PagedResultRequest : IPagedResultRequest
    {
        /// <summary>
        /// 共多少页
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// 行总数
        /// </summary>
        public int Rows { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex => Page;
        /// <summary>
        /// 每页显示
        /// </summary>
        public int PageSize => Rows;
    }
}
