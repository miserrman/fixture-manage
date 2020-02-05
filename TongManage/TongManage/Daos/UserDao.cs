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
        public IList<User> selectAllUsers()
        {
            return BaseDao.QueryForList<User>("SelectAllUsers");
        }

        public User selectUserById(int id)
        {
            return BaseDao.SelectById<User>("SelectUserById", id);
        }

        public User selectUserByUserName(string userName)
        {
            return BaseDao.SelectByKey<User>("SelectUserByUserName", userName);
        }

        public int insertUser(User user)
        {
            return BaseDao.Insert<User>("InsertUser", user);
        }

        public int updateUser(User user)
        {
            return BaseDao.Update<User>("UpdateUser", user);
        }

        public int deleteUserById(int id)
        {
            return BaseDao.Delete("DeleteUserById", id);
        }
    }
}