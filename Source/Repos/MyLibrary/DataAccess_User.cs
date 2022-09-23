using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLibrary
{
    public class DataAccess_User
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public List<User> PasswordValidation(string Username, string Password)
        {          
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<User>("dbo.spUser_ValidateUser @Username,@Password", new { Username = Username, Password = Password}).ToList();
                return output;
            }
        }


        public List<User> GetUsersByLastname(string Lastname)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<User>("dbo.spUser_GetByLastname @Lastname",new {Lastname = Lastname}).ToList();
                return output;
            }
        }

        public List<User> GetUserList(string Lastname)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<User>("dbo.spUser_GetUserList").ToList();
                return output;
            }
        }

        public List<User> Add_New_User(string Firstname,string Lastname, string LicensePlateNumber)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<User>("dbo.spUser_Add @Firstname,@Lastname,@Licenseplatenumber", new { Firstname = Firstname, Lastname = Lastname, Licenseplatenumber = LicensePlateNumber }).ToList();
                return output;
            }
        }

        public List<User> Update(string UserID,string Firstname, string Lastname, string LicensePlateNumber)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<User>("dbo.spUser_Update @UserID,@Firstname,@Lastname,@Licenseplatenumber", new { UserID=UserID, Firstname = Firstname, Lastname = Lastname, Licenseplatenumber = LicensePlateNumber }).ToList();
                return output;
            }
        }

        public List<User> Delete(string UserID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<User>("dbo.spUser_Delete @UserID", new { UserID = UserID}).ToList();
                return output;
            }
        }
        
    }
}
