using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Core.Data
{
   public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity,new();

        int SaveChanges();

        IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : BaseEntity, new();

        IEnumerable<TEntity> SqlQuery<TEntity>(string sql, params object[] parameters) where TEntity:BaseEntity,new();

        int ExecuteSqlcommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null,
            params object[] parameters) ;

        void Detach(Object entity);
    }
}
