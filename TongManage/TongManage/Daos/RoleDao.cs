using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    /// <summary>
    /// author: rentianhe
    /// date: 2020/2/3
    /// </summary>
    public class RoleDao
    {
        /// <summary>
        /// 查询所有角色权限
        /// </summary>
        /// <param name="role"></param>
        /// <returns>角色权限列表</returns>
        public IList<Role> selectAllRoles(Role role)
        {
            return BaseDao.QueryForList<Role>("SelectAllRoles", role);
        }

        /// <summary>
        /// 查询单条角色权限信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns>单条角色权限</returns>
        public Role selectRoleById(Role role)
        {
            return BaseDao.QueryForObject<Role>("SelectRoleById", role);
        }

        /// <summary>
        /// 插入单条角色权限
        /// </summary>
        /// <param name="role">角色权限类</param>
        /// <returns>操作状态码</returns>
        public int insertRole(Role role)
        {
            return BaseDao.Insert<Role>("InsertRole", role);
        }

        /// <summary>
        /// 更新单条角色权限
        /// </summary>
        /// <param name="role">角色权限类</param>
        /// <returns>操作状态码</returns>
        public int updateRole(Role role)
        {
            return BaseDao.Update<Role>("UpdateRole", role);
        }

        /// <summary>
        /// 删除单条角色权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteRoleById(Role role)
        {
            return BaseDao.Delete<Role>("DeleteRoleById", role);
        }
    }
}