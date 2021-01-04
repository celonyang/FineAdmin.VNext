﻿using DapperExtensions.SqlServerExt;
using FineAdmin.IRepository;
using FineAdmin.Model;
using System;
using System.Collections.Generic;

namespace FineAdmin.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        #region CRUD
        /// <summary>
        /// 根据主键返回实体
        /// </summary>
        public T GetById(int Id)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.GetById<T>(Id);
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        public int Insert(T model)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.Insert<T>(model);
            }
        }
        /// <summary>
        /// 根据主键修改数据
        /// </summary>
        public int UpdateById(T model)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.UpdateById<T>(model);
            }
        }
        /// <summary>
        /// 根据主键修改数据 修改指定字段
        /// </summary>
        public int UpdateById(T model, string updateFields)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.UpdateById<T>(model, updateFields);
            }
        }
        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        public int DeleteById(int Id)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.DeleteById<T>(Id);
            }
        }
        /// <summary>
        /// 根据主键批量删除数据
        /// </summary>
        public int DeleteByIds(object Ids)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.DeleteByIds<T>(Ids);
            }
        }
        /// <summary>
        /// 根据条件删除
        /// </summary>
        public int DeleteByWhere(string where)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.DeleteByWhere<T>(where);
            }
        }
        #endregion
        /// <summary>
        /// 获取分页数据
        /// </summary>
        public IEnumerable<T> GetByPage(SearchFilter filter, out int total)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.GetByPage<T>(filter.PageIndex, filter.PageSize, out total, filter.ReturnFields, filter.Where, filter.Param, filter.OrderBy, filter.Transaction, filter.CommandTimeout);
            }
        }
        /// <summary>
        /// 获取分页数据 联合查询
        /// </summary>
        public IEnumerable<T> GetByPageUnite(SearchFilter filter, out int total)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.GetByPageUnite<T>(filter.Prefix, filter.PageIndex, filter.PageSize, out total, filter.ReturnFields, filter.Where, filter.Param, filter.OrderBy, filter.Transaction, filter.CommandTimeout);
            }
        }
        /// <summary>
        /// 返回整张表数据
        /// returnFields需要返回的列，用逗号隔开。默认null，返回所有列
        /// </summary>
        public IEnumerable<T> GetAll(string returnFields = null, string orderby = null)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.GetAll<T>(returnFields, orderby);
            }
        }
        /// <summary>
        /// 根据查询条件获取数据
        /// </summary>
        public IEnumerable<T> GetByWhere(string where = null, object param = null, string returnFields = null, string orderby = null)
        {
            using (var conn = DbContext<T>.GetConnection())
            {
                return conn.GetByWhere<T>(where, param, returnFields, orderby);
            }
        }
    }
}
