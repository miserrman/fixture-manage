﻿using System;

/**
 * author: zhouxing
 * date: 2020/01/22
 */
namespace Models
{
    public class User
    {
        private int id;
        private string name;
        private string userPhoto;
        private int roleId;
        private string password;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string UserPhoto { get => userPhoto; set => userPhoto = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public string Password { get => password; set => password = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}