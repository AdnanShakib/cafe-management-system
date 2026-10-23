using Cafe_Management.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data_Access_Layer
{
    class UserDataAccess:DataAccess
    {
        public bool UserRegister(User user)
        {
            string sql = "INSERT INTO Employees(Name,Username,Password,Email,DateOfBirth,Gender,PhoneNumber,UserType) VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.PhoneNumber + "','"+user.UserType+"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        //public bool LoginValidation(string username, string password)
        //{
        //    string sql = "SELECT * FROM Employees WHERE Username='" + username + "' AND Password='" + password + "'";
        //    SqlDataReader reader = this.GetData(sql);
        //    if (reader.HasRows)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        public string LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Employees WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            User user = new User();
            if (reader.HasRows)
            {
                reader.Read();
                
               
                return user.UserType = reader["UserType"].ToString();
               

            }
            else
            {
                return null;
            }
            
        }
    }
}
