using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model.Entities.Base;

namespace AdminLTE.Core.Data
{
   public interface IRepository<TEntity,  TPrimaryKey> where TEntity : class,IEntity<TPrimaryKey>
    {
        /// <summary>
        /// 通过主键得到实体
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>实体对象</returns>
        TEntity GetById(TPrimaryKey id);

        /// <summary>
        /// 新增一个实体数据
        /// </summary>
        /// <param name="entity">要新增的实体数据</param>
        void Insert(TEntity entity);

        /// <summary>
        /// 批量新增多个实体数据
        /// </summary>
        /// <param name="entities">实体数据集合</param>
        void Insert(IEnumerable<TEntity> entities);

        /// <summary>
        /// 修改一个实体数据
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// 修改多个实体数据
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<TEntity> entities);

        /// <summary>
        /// 通过主键删除一条实体数据
        /// </summary>
        /// <param name="id"></param>
        void Delete(TPrimaryKey id);
        /// <summary>
        /// 通过实体删除一条数据
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// 得到可以查询的 <see cref="System.Linq.IQueryable{T}"/> 对象。
        /// </summary>
        IQueryable<TEntity> Tables { get; }

        /// <summary>
        /// 得到可以查询的 <see cref="System.Linq.IQueryable{T}"/> 对象，但是不监控实体的状态。
        /// </summary>
        IQueryable<TEntity> TableNoTracking { get; }

    }

    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {

    }
}
