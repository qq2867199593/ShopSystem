using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ShopSystem
{
    class DBConnect
    {
        private string conStr = "";

        public bool AccountFind(string account,string password)
        {
            string sqlStr = string.Format("select count(*) from userInfo where uAccount = {0} AND uPassword = {1}", account, password);
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlStr, conn); 
            
            conn.Open();
            bool isFinded = (bool)cmd.ExecuteScalar();
            conn.Close();
            return isFinded;
        }

    }
}
