using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;
using TongManage.Daos;
using TongManage.Utils;

namespace TongManage.Services
{
    public class UserService
    {
        static UserDao userDao = new UserDao();
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        public User register(User user)
        {
            user.GmtCreate= DateTime.Now.ToLocalTime();
            user.GmtModified= DateTime.Now.ToLocalTime();
            user.Password = MD5Util.MD5Encrypt(user.Password);//密文存储
            userDao.insertUser(user);
            return user;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passW">密码</param>
        /// <returns></returns>
        public string login(string userName, string passW)
        {
            User user = userDao.selectUserByUserName(userName);
            if (user.Password == MD5Util.MD5Encrypt(passW))
            {
                //生成token
                TokenInfo userInfo = new TokenInfo();
                userInfo.UserName = userName;
                userInfo.Pwd = passW;
                //userInfo.workCell = user.WorkCell;
                //数据库表缺少workCell字段
                return TokenHelper.GenToken(userInfo);
            }
            else
            {
                return null;
            }
               
        }

        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public int delUser(string userName)
        {
            User user = userDao.selectUserByUserName(userName);
            if(user==null)
            {
                return 0;
            }
            else
            {
                int temp = userDao.deleteUserById(user.Id);
                if(temp==1)
                {
                    User user1 = userDao.selectUserById(user.Id);
                    user1.GmtModified= DateTime.Now.ToLocalTime();
                    userDao.updateUser(user1);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="int">用户id</param>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        public User setUserInfo(int id,User user)
        {
            User user1 = userDao.selectUserById(id);
            user.Id = id;
            user.GmtModified= DateTime.Now.ToLocalTime();
            user.GmtCreate = user1.GmtCreate;
            int result = userDao.updateUser(user);
            if (result == 0)
                return null;
            else
                return user;
        }

        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public string findPassW(string userName)
        {
            //通过邮箱找回
            //数据库需要进行更改，添加邮箱字段
            return null;
        }

        /// <summary>
        /// 获得用户列表信息
        /// </summary>
        /// <returns></returns>
        public List<User> getUserList()
        {
            return userDao.selectAllUsers().ToList();
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public User getUserById(int id)
        {
            return userDao.selectUserById(id);
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public User getUserByName(string userName)
        {
            return userDao.selectUserByUserName(userName);
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="workNo">工号</param>
        /// <returns></returns>
        public User getUserByWorkNo(string workNo)
        {
            //数据库的表需要进行更改才能完成此功能
            //添加workNo字段
            return null;
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="workCell">部门id</param>
        /// <returns></returns>
        public List<User> getUserListByWorkCell(string workCell)
        {
            //缺字段
            return null;
        }
    }
}