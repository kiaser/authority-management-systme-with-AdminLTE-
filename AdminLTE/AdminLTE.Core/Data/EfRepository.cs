using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Core.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        #region Fields
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private readonly IDbContext _dbContext;

        /// <summary>
        /// 当前实体集合对象
        /// </summary>
        private IDbSet<TEntity> _entities;
        #endregion

        #region Ctor
        //todo 临时解决方案
        public EfRepository()
        {
            _dbContext = new DataBaseContext();
        }

        public EfRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Utilities
        /// <summary>
        /// 得到数据执行过程中抛出的错误中更加详细的信息。
        /// </summary>
        /// <param name="exc">Exception</param>
        /// <returns>Error</returns>
        protected string GetFullErrorText(DbEntityValidationException exc)
        {
            var msg = string.Empty;
            foreach (var validationErrors in exc.EntityValidationErrors)
                foreach (var error in validationErrors.ValidationErrors)
                    msg += string.Format("Property: {0} Error: {1}", error.PropertyName, error.ErrorMessage) + Environment.NewLine;
            return msg;
        }
        #endregion

        #region Methods
        public virtual TEntity GetById(int id)
        {
            return Entities.SingleOrDefault(t => t.Id == id);
        }

        public virtual void Insert(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            try
            {
                Entities.Add(entity);

                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw new EfDbExcption(GetFullErrorText(e));
            }
        }

        public virtual void Insert(IEnumerable<TEntity> entities)
        {
            if (entities == null || !entities.Any()) throw new ArgumentNullException(nameof(entities));

            try
            {
                foreach (var entity in entities)
                {
                    Entities.Add(entity);
                }
                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw new EfDbExcption(GetFullErrorText(e));
            }
        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            try
            {
                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw new EfDbExcption(GetFullErrorText(e));
            }
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
            if (entities == null || entities.Any()) throw new ArgumentNullException(nameof(entities));

            try
            {
                foreach (var entity in entities)
                {
                    if (Entities.Local.FirstOrDefault(t => ReferenceEquals(t, entity)) == null)
                    {
                        Entities.Add(entity);
                    }
                }
                _dbContext.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {
                throw new EfDbExcption(GetFullErrorText(e));
            }
        }
        /// <summary>
        /// 软删除，所以不需要
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 软删除，所以不需要
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region Properties

        public IQueryable<TEntity> Tables => Entities;
        public IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();

        protected virtual IDbSet<TEntity> Entities
        {
            get
            {
                if (_entities != null) return _entities;
                _entities = _dbContext.Set<TEntity>();

                return _entities;
            }
        }

        #endregion
    }
}
