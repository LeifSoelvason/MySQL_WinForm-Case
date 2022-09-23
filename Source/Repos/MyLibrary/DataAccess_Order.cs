using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLibrary
{
    public class DataAccess_Order
    {
        public List<Order> GetOrderByUserID(string UserID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<Order>("spOrder_Search @UserID", new { UserID = UserID }).ToList();
                return output;
            }
        }

        public List<Order> Add_New_Order(string UserID, string Km, string Licenseplatenumber)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Users_DB")))
            {
                var output = connection.Query<Order>("dbo.spOrder_Add @UserID,@Km,@Licenseplatenumber", new { UserID = UserID, Km = Km, Licenseplatenumber = Licenseplatenumber }).ToList();
                return output;
            }
        }
    }
}
