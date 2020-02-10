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
    public class UserDao
    {
        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>用户列表</returns>
        public IList<User> selectAllUsers(User user)
        {
            return BaseDao.QueryForList<User>("SelectAllUsers", user);
        }

        /// <summary>
        /// 查询处于同一部门的所有用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>用户列表</returns>
        public IList<User> selectUsersByWorkcell(User user)
        {
            return BaseDao.QueryForList<User>("SelectAllUsers", user);
        }

        /// <summary>
        /// 查询单条用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns>单个用户信息</returns>
        public User selectUserById(User user)
        {
            return BaseDao.QueryForObject<User>("SelectUser", user);
        }

        /// <summary>
        /// 通过用户名查询用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>单个用户信息</returns>
        public User selectUserByUserName(User user)
        {
            return BaseDao.QueryForObject<User>("SelectUser", user);
        }

        /// <summary>
        /// 通过工号查询用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>单个用户信息</returns>
        public User selectUserByWorkNo(User user)
        {
            return BaseDao.QueryForObject<User>("SelectUser", user);
        }

        /// <summary>
        /// 插入单个用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns>操作状态码</returns>
        public int insertUser(User user)
        {
            return BaseDao.Insert<User>("InsertUser", user);
        }

        /// <summary>
        /// 更新单个用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns>操作状态码</returns>
        public int updateUser(User user)
        {
            return BaseDao.Update<User>("UpdateUser", user);
        }

        /// <summary>
        /// 删除单条用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteUserById(User user)
        {
            return BaseDao.Delete<User>("DeleteUserById", user);
        }
    }
}