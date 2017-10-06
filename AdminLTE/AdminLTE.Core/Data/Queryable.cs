using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Core.Entity;

namespace AdminLTE.Core.Data
{
   public static class Queryable
    {
        public static IQueryable<TEntity> PageBy<TEntity>(this IOrderedQueryable<TEntity> entities,
            IPagedResultRequest pagedResultRequest)
        {
            if(entities== null) throw new ArgumentNullException(nameof(entities));

            return PageBy(entities,pagedResultRequest.PageSize,pagedResultRequest.PageIndex);
        }

        public static IQueryable<TEntity> PageBy<TEntity>(this IOrderedQueryable<TEntity> entities, int pageSize,
            int pageIndex)

        {
            if (entities == null) throw new ArgumentNullException(nameof(entities));
            //pageIndex从1开始
            int startIndex = pageSize * (pageIndex - 1);
            return entities.Skip(startIndex).Take(pageSize);
        }
    }
}
