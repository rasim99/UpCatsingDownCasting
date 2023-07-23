using Service.Enum;
using Service.Helpers.Constans;
using Service.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class Account : IAccount
    {
        public string Login(string email, string password, int role)
        {
            if (email == AccountConstant.Email && password == AccountConstant.Password)
            {
                if (CheckRole(role))
                {
                    return AccountConstant.SuperAdminValidMessage;
                }
                else
                {
                    return AccountConstant.SuperAdminInValidMessage;
                }
            }
            else
            {
                return AccountConstant.PasswordOrEmailInValid;
            }
        }


        public bool CheckRole(int role)
        {
            //switch (role)
            //{
            //    case (int)Roles.SuperAdmin:
            //        return true;
            //    default:
            //        return false;
            //}
            return role == (int)Roles.SuperAdmin;

        }
    }
}
