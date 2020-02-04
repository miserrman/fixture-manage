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
        public IList<Role> selectAllRoles()
        {
            return BaseDao.QueryForList<Role>("SelectAllRoles");
        }

        public Role selectRoleById(int id)
        {
            return BaseDao.SelectById<Role>("SelectRoleById", id);
        }

        public int insertRole(Role role)
        {
            return BaseDao.Insert<Role>("InsertRole", role);
        }

        public int updateRole(Role role)
        {
            return BaseDao.Update<Role>("UpdateRole", role);
        }

        public int deleteRoleById(int id)
        {
            return BaseDao.Delete("DeleteRoleById", id);
        }
    }
}