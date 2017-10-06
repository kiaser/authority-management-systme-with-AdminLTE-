using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Core.Entity;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Core.Data
{
    public abstract class BaseService<TEntity> where TEntity : BaseEntity,new()
    {
        #region Fields

        private readonly IDbContext _dbContext;
        private readonly EfRepository<TEntity> _efRepository;

        #endregion

        #region Ctor
        //todo 临时处理
        protected BaseService()
        {
            _dbContext = new DataBaseContext();
            _efRepository = new EfRepository<TEntity>();
        }

        #endregion

        #region Utilities

        #endregion

        #region Methods
        protected TEntity GetEntity(Expression<Func<TEntity, bool>> predicate)
        {
            return _efRepository.Tables.FirstOrDefault(predicate);
        }

        protected TEntity GetEntity(int id)
        {
            return GetEntity(t => t.Id == id);
        }

        protected void Insert(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _efRepository.Insert(entity);
        }

        protected void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _efRepository.Update(entity);
        }

        protected void Delete(int id)
        {
            var entity = GetEntity(id);
            if (entity != null) Delete(entity);
        }

        private void Delete(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            entity.IsDeleted = true;
            _efRepository.Update(entity);

        }


        protected List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate,
            IPagedResultRequest pagedResultRequest, out int total)
        {
            var queryable = GetQueryable(predicate);
            total = queryable.Count();

            return queryable.OrderBy(t => t.Id).PageBy(pagedResultRequest).ToList();
        }


        protected IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> queryable = TableNoTracking;

            if (predicate != null) queryable = queryable.Where(predicate);

            return queryable;
        }

        protected List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> queryable = Table;
            if (predicate != null) queryable = queryable.Where(predicate);

            return queryable.ToList();

        }



        #endregion

        #region Properties


        protected IQueryable<TEntity> Table => _efRepository.Tables;

        protected IQueryable<TEntity> TableNoTracking => _efRepository.TableNoTracking;

        #endregion
    }
}
